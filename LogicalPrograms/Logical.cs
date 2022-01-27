using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumbers
    {
        public void Coupon()
        {
            //assign numbers and characters
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Console.WriteLine("Please Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            var chars = new char[num];
            var Random = new Random();

            //Loop to generate the random coupon
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = characters[Random.Next(characters.Length)];
            }
            var finalstring = new string(chars);
            // To print the generate coupon
            Console.WriteLine(finalstring);
        }
    }
}