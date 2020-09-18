using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Reverse Intege

            Console.WriteLine($"Sandbox problem {nameof(ReverseInteger)}");
            int[] list = {10,-12345,300,450,25, 1534236469 };
            foreach (var num in list)
            {
                Console.WriteLine($"Reverse of {num} is: {ReverseInteger.Reverse(num)}");
            }

            #endregion

            #region MyAtoi

            string[] examples = {"   +0 123"
                ,"1", "3.14159", "+-2","-", "+", "", "42", "   -42" , "4193 with words", "words and 987", "4asd34", "-91283472332", "91283472332" };

            foreach (var str in examples)
            {
                Console.WriteLine($"\nthe Atoi result: {Atoi.MyAtoi(str)}");
            }
            #endregion
        }
    }
}
