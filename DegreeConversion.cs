using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgram
{
    class DegreeConversion
    {
        public void DegreeConv()
        {
            int Celcius;
            Console.WriteLine("Enter the Temperature in Celcius");
            Celcius = int.Parse(Console.ReadLine());
            //Converting Celsius to Fahrenheit
            int Fahrenheit = (Celcius * 9 / 5) + 32;
            Console.WriteLine("After Converting: " + Fahrenheit);

            Console.WriteLine("Enter the Farhenheit");
            Celcius = int.Parse(Console.ReadLine());
            Celcius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("After Converting: " + Celcius);
        }

    }
}
