using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class SqrtNewtonMethod
    {
        public static void SqrtMethod()
        {
            Console.WriteLine("Enter the number:");

            double c = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1e-15;    // relative error tolerance
            double t = c;              // estimate of the square root of c

            // repeatedly apply Newton update step until desired precision is achieved
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            // print out the estimate of the square root of c
            Console.WriteLine(t);
        }
    }
}
