using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
	public class dayweek
	{
		public static int dayofweek(int d, int m, int y)
		{
			int[] t = { 0, 3, 2, 5, 0, 3, 5,
							1, 4, 6, 2, 4 };
			y -= (m < 3) ? 1 : 0;

			return (y + y / 4 - y / 100 + y / 400
							+ t[m - 1] + d) % 7;
		}


		// taking the variables
		public static void days()
		{
			Console.WriteLine("Enter the day");
			int days = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the month");
			int month = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the year");
			int year = Convert.ToInt32(Console.ReadLine());
			int day = dayofweek(days, month, year);
			if (day == 0)
				Console.WriteLine("Day is Sunday");
			else if (day == 1)
				Console.WriteLine("Day is Monday");
			else if (day == 2)
				Console.WriteLine("Day is Tuesday");
			else if (day == 3)
				Console.WriteLine("Day is Wednesday");
			else if (day == 4)
				Console.WriteLine("Day is Thursday");
			else if (day == 5)
				Console.WriteLine("Day is Friday");
			else if (day == 6)
				Console.WriteLine("Day is Saturday");
			else
				Console.WriteLine("Wrong Number ");
		}

	}
}





