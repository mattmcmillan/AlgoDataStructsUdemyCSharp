using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCodingAlgoBootcampDataStructs
{
    class Palindrome
    {
        //solution one
        //public static bool isPalindrome(string input)
        //{
        //    string reversed = ReverseString.Reverse(input);

        //    return reversed == input;
        //}

        //solution two
        public static bool isPalindrome(string input)
        {
            //only need to iterate through the first half of the string.
            //check the second half is redundant, as we perform the same checks during the first hald
            int inputHalfLength = input.Length / 2;

            for (int i = 0; i < inputHalfLength; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
