using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class CompountInterst
    {

        public static void intesrest()
        {
            Console.WriteLine("Enter the principle amount:");
            double principle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of years");
            int yrs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest ");
            double rate = Convert.ToDouble(Console.ReadLine());
            double payment = 0;
            int n = 12 * yrs;
            double r = rate / (12 * 100);
            payment = (principle * r) / (1 - Math.Pow((1 + r), -n));

            Console.WriteLine("Payment is: " + payment);

        }
    }
}
