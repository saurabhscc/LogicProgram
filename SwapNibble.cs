using System;
using System.Collections.Generic;
using System.Text;

namespace LogicProgram
{
    class SwapNibble
    {
        int SwapNibbles(int x)
        {
            return ((x & 0x0F) << 4 |//it will give last 4 bits of 100 00000100 using bitwise we are shifting last 4 bits to left 4 times and make 1st 4 bits as 0,result is 01000000.
                    (x & 0xF0) >> 4);//1st 4bits 01100000 using bitwise we are shifting last 4 bits to right 4 times and make 1st 4 bits as 0,result 00000110
        }

        //  This is Driver code
        public void SwapNibbles()
        {
            int x = 100;
            Console.WriteLine(SwapNibbles(x));
        }


    }
}