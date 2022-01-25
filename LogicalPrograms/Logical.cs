using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Prime
    {
        public static void PrimeNumbers()
        {
            Console.WriteLine("Enter the Numbers : ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool flag = false;

            for (int i = 2; i < num; i++)
            {

                if (num % i == 0)
                {
                    flag = true;
                }
            }

            if (flag)
            {
                Console.WriteLine("Number is not prime");
            }
            else
            {
                Console.WriteLine("Number is a prime");
            }
        }

    }
}
