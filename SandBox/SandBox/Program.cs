using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] list = {10,-12345,300,450,25, 1534236469 };

            foreach (var num in list)
            {
                Console.WriteLine($"Reverse of {num} is: {ReverseInteger.Reverse(num)}");
            }
        }
    }
}
