using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольную строку:");
            string str = Console.ReadLine();

            int n = str.Length;
            int count = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (str[i] != str[j])
                    {
                        Console.WriteLine(str[i] + "" + str[j]);
                        count += 1;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество найденных комбинаций:" + count);
            Console.ReadKey();
        }
    }
}
