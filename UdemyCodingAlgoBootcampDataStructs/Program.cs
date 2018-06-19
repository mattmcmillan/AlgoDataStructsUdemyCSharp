using System;

namespace UdemyCodingAlgoBootcampDataStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversedInput = ReverseString.Reverse("Plingo");
            bool isPalindrome = Palindrome.isPalindrome("oooooo");

            int reversedString = ReverseInt.ReversePositiveInteger(6009);

            int highestRepeatedChar = DictionaryProblems.GetHighestesRepeatedCharInString("RipVanWinklyeRurberbeng");
            FizzBuzz.DoFizzBuzz(30);

            int[] arrayToChunk = new int[] { 5, 1, 2, 77, 8, 9, 44, 33, 65, 72, 21 };
            ArrayChunk.ChunkArray(arrayToChunk, 3);
        }

    }
}
