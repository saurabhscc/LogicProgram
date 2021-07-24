using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgram
{
    class PrimeNumber
    {
        public int n;
        public int i;
        public int Remainder;
        public void CheckPrimeNumber()
        {
            Console.WriteLine("Enter a Number");
            n = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}


