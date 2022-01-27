using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class Temperatureconversion
    {
        public static void Temp()
        {

            double fahrenheit;
            double celsius;
            Console.WriteLine("Enter the Temperature");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ebter the unit to Convert: C for celcius or F for Fahrenheit");
            string convert_var = Console.ReadLine();

            if (convert_var == "C")
            {
                celsius = ((temp - 32) * 5) / 9;
                Console.WriteLine(+temp + " Fahrenheit: " + celsius + " Celsius");

            }
            else if (convert_var == "F")
            {
                fahrenheit = (temp * 9) / 5 + 32;
                Console.WriteLine(+temp + " Celsius : " + fahrenheit + " fahrenheit");
            }


        }
    }
}
