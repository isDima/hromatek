# hromatek
Тестовое задание

Пожалуйста, выполните тестовое задание.

Напишите консольное приложение на C#. В консоль вводится произвольная строка. Задача - вывести в консоль все комбинации символов из введённой строки БЕЗ ПОВТОРОВ (предыдущее значение не запоминается). В конце вывести количество найденных комбинаций.
Например:

aabc

abac

baac

aacb

acab

caab

abca

baca

acba

caba

bcaa

cbaa

Всего вариантов = 12

<code>
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
</code>
