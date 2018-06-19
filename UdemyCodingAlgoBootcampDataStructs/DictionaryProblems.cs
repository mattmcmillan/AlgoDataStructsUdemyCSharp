using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCodingAlgoBootcampDataStructs
{
    static class DictionaryProblems
    {
        //includes spaces as character
        //In the case that there are characters that repeat the same numbers of times, 
        //this method returns the first character that happens to have the repeated value
        public static char GetHighestesRepeatedCharInString(string input)
        {
            Dictionary<char, int> charsInString = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charsInString.ContainsKey(c))
                {
                    charsInString[c] += 1;
                }
                else
                {
                    charsInString[c] = 1;
                }
            }

            int max = 0;
            char maxChar = input[0];
            int lowestIndex = input.Length - 1;

            char[] inputCharArray = input.ToCharArray();

            foreach (char c in charsInString.Keys)
            {
                //if max values are equal compare indexes in original input
                if(charsInString[c] == max)
                {
                    int currentCharIndex = 0;
                    if(currentCharIndex > lowestIndex)
                    {
                        max = charsInString[c];
                        maxChar = c;
                    }
                }
                else if (charsInString[c] > max)
                {
                    max = charsInString[c];
                    maxChar = c;
                }
            }

            return maxChar;
        }
    }
}
