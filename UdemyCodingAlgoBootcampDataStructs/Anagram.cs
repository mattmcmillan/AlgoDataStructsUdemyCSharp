using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UdemyCodingAlgoBootcampDataStructs
{
    static class Anagram
    {
        public static bool isAnagram(string stringA, string stringB)
        {
            Dictionary<char, int> aCharMap = buildCharMap(stringA.StripSpacesAndPunctuation().ToLower());
            Dictionary<char, int> bCharMap = buildCharMap(stringB.StripSpacesAndPunctuation().ToLower());

            if(aCharMap.Keys.Count != bCharMap.Keys.Count)
            {
                return false;
            }

            foreach (char c in aCharMap.Keys)
            {
                //first check if second string event contains the same char as first string
                if (!bCharMap.ContainsKey(c))
                {
                    return false;
                }

                //second check if character repeats the same number of times in each string
                if (aCharMap[c] != bCharMap[c])
                {
                    return false;
                }
            }

            return true;
        }

        private static Dictionary<char, int> buildCharMap(string input)
        {
            Dictionary<char, int> charMap = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charMap.ContainsKey(c))
                {
                    charMap[c]++;
                }
                else
                {
                    charMap[c] = 1;
                }
            }

            return charMap;
        }


        ////this solution needs more work, mainly with the regex matching pattern
        //public static bool isAnangram(string stringA, string stringB)
        //{
        //    return cleanString(stringA) == cleanString(stringB);
        //}

        //public static List<char> cleanString(string input)
        //{
        //    string pattern = "[^A-Z0-9]ig";
        //    string replacement = "";

        //    Regex rgx = new Regex(pattern);
        //    string regexResult = rgx.Replace(input, replacement);
        //    List<char> resultCharList = new List<char>(regexResult.ToLower().ToCharArray());
        //    resultCharList.Sort();

        //    return resultCharList;

        //}
    }
    public static class StringExtension
    {
        public static string StripSpacesAndPunctuation(this string s)
        {
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (!char.IsPunctuation(c) && c != ' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
