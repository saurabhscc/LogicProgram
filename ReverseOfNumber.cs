using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgram
{
    class ReverseOfNumber
    {
        public int Number;
        public int Reverse;
        public int Remainder;
        public void ReverseNumber()
        {
            Console.WriteLine("Enter a No. to reverse"); 
            Number = int.Parse(Console.ReadLine());
            Reverse = 0;
            while (Number > 0)
            {
                Remainder = Number % 10; 
                Reverse = (Reverse * 10) + Remainder; 
                Number = Number / 10; 
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }
    }
}
