using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class deciToBinary
    {
        public static void Binary()
        {
            Console.WriteLine("ENter the decimal value");
            int deciVal = Convert.ToInt32(Console.ReadLine());
            int val;
            string a = "";

            Console.WriteLine("Decimal: {0}", deciVal);
            while (deciVal >= 1)
            {
                val = deciVal / 2;
                a += (deciVal % 2).ToString();
                deciVal = val;
            }
            string binValue = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                binValue = binValue + a[i];
            }
            Console.WriteLine("Binary: {0}", binValue);
        }
    }
}

