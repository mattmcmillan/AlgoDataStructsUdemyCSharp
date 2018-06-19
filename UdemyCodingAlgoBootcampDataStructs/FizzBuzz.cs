using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCodingAlgoBootcampDataStructs
{
    class FizzBuzz
    {
        public static void DoFizzBuzz(int input)
        {
            for (int i = 1; i <= input; i++)
            {
   
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                } 
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
