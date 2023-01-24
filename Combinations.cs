using System;
namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your string:");
            char[] inputString = Console.ReadLine().ToCharArray();
            int len = inputString.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (i <= j)
                        Console.Write($"{inputString[i]}{inputString[j]} ");
                }
            }
            Console.WriteLine($"\nNumber of combinations: {(len * len + len) / 2}");

            Console.ReadKey();
        }
    }
}
