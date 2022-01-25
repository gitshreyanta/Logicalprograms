using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Perfect
    {
        public static void PerfectNumbers()
        {
            int num, i, sumOffact = 0;

            Console.WriteLine("Enter the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num / 2; i++)
            {

                if (num % i == 0)
                    sumOffact = sumOffact + i;
            }

            if (sumOffact == num)
            {
                Console.WriteLine("Given number is perfect : " + num);
            }
            else
            {
                Console.WriteLine("Given number is not perfect : " + num);
            }

        }

    }
}








