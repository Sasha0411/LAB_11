using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB11
{
    internal class Program
    {

        static void PrintMultiplicationTable(int number)
            {
                if (number == 0)
                {
                    // Вивести всю таблицю множення
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            Console.Write($"{i} * {j} = {i * j}\t");
                        }
                        Console.WriteLine();
                    }
                }
                else if (number >= 1 && number <= 9)
                {
                    // Вивести стовпець таблиці множення для заданого числа
                    Console.WriteLine($"Таблиця множення для {number}:");
                    for (int i = 1; i <= 9; i++)
                    {
                        Console.WriteLine($"{number} * {i} = {number * i}");
                    }
                }
                else
                {
                    Console.WriteLine("Неправильне число. Будь ласка, введіть число від 1 до 9.");
                }
            }

            static void Main(string[] args)
            {
            Console.WriteLine("Горкун Олександр");
            Console.Write("Введіть число (або 0 для виведення всієї таблиці): ");
                int number = int.Parse(Console.ReadLine());

                PrintMultiplicationTable(number);
            }
        }
    }
