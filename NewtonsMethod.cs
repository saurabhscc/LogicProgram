using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgram
{
    class NewtonsMethod
    {
        public void sqrt()
        {
            Console.WriteLine("Enter a positive number :");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1.0e-15; 
            double t = c;              

            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }

            // print out the estimate of the square root of c
            Console.WriteLine(t);



        }
    }
}

