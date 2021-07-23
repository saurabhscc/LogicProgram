using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgram
{
    class FibbonaciSeries
    {
        public int Number1 = 0;
        public int Number2 = 1;
        public int Number3;
        public int Var_i;
        public int ReadNumber;
        public void CheckFibonacciSeries()
        {

            Console.Write("Enter the number of elements: "); 
            ReadNumber = int.Parse(Console.ReadLine()); 
            Console.WriteLine(Number1 + " " + Number2 + " "); 
            for (Var_i = 2; Var_i < ReadNumber; ++Var_i)     
            {
                Number3 = Number1 + Number2; 
                Console.WriteLine(Number3 + " "); 
                Number1 = Number2; 
                Number2 = Number3;
            }

        }
    }
}
