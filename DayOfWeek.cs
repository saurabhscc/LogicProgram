using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgram
{
    class DayOfWeek
    {
        public void Days()
        {
            int d, m, y;
            Console.WriteLine("Enter a day");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter month");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter year");
            y = int.Parse(Console.ReadLine());

            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] Day = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thrusday", "Friday", "Saturday" };
            int y0 = y - (14 - m) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine("It's " + Day[d0] + " on " + d + " " + month[m - 1] + ", " + y);


        }
    }
}
