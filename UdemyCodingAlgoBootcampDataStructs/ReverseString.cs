using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCodingAlgoBootcampDataStructs
{
    static class ReverseString
    {
        //my solution
        //public static string Reverse(string input)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    for (int i = input.Length - 1; i > -1; i--)
        //    {
        //        sb.Append(input[i]);
        //    }

        //    return sb.ToString();
        //}

        //another solution with foreach loop and inserting at the beginning of the string.
        public static string Reverse(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                sb.Insert(0, c);
            }

            return sb.ToString();
        }
    }
}
