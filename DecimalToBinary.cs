using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgram
{
    class DecimalToBinary
    {
        public void toBinary()
        {
            Console.WriteLine("Enter the number to convert");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] binaryNum = new int[number];
            int i = 0;
            while (number > 0)
            {
                binaryNum[i] = number % 2;
                number = number / 2;
                i++;
            }
            for (int k = i - 1; k >= 0; k--)
            {
                Console.WriteLine(binaryNum[k]);
            }
        }


    }
}

