using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCodingAlgoBootcampDataStructs
{
    static class ReverseInt
    {
        public static int ReversePositiveInteger(int input)
        {
            int reverse = 0;
            while(input > 0)
            {
                int remainder = input % 10;
                reverse = (reverse * 10) + remainder;
                input = input / 10;
            }

            return reverse;
        }
    }
}
