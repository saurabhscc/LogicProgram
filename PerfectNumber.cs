using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgram
{
    class PerfectNumber
    {
        public int Number;
        public int i;
        public int Result;

        public void CheckPerfectNumber()
        {
            Console.WriteLine("Input the  number : ");  
            Number = int.Parse(Console.ReadLine());
            Result = 0;//By Default Result is 0
            Console.WriteLine("The positive divisor  : ");
            for (i = 1; i < Number; i++) 
            {
                if (Number % i == 0) 
                {
                    Result = Result + i;  
                    Console.WriteLine("{0}  ", i); //{0} Format string  
                }
            }
            Console.WriteLine("The sum of the divisor is : {0}", Result);  
            if (Result == Number)
                Console.WriteLine("So, the number is perfect.");
            else
                Console.WriteLine("So, the number is not perfect.");
        }
    }
}
