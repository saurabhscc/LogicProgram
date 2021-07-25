using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgram
{
    class MonthlyPayment
    {
        public void Pay()
        {
            int P, Y, R;
            Console.WriteLine("Enter the year");
            Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Principal Loan");
            P = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Int Rate");
            R = int.Parse(Console.ReadLine());
            int n = 12 * Y;
            int r = R / (12 * 100);
            int payment = P * r / 1 - (1 + r) ^ (-n);
            Console.WriteLine("Monthly Payment is" + payment);

        }

    }
}

