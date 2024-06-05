using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB11
{
    internal class Program
    {
        static void SwapNumbers(double number1, double number2)
        {
            double temp = number1;
            number1 = number2;
            number2 = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");
            Console.Write("Введіть перше число: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Числа до обміну: number1 = {number1}, number2 = {number2}");

            SwapNumbers(number1, number2); // Виклик методу

            Console.WriteLine($"Числа після обміну: number1 = {number1}, number2 = {number2}");
        }
    }
} 
