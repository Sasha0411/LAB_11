using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB11
{
    internal class Program
    {
        static void IsDivisible()
        {
            Console.Write("Введіть перше число: ");
            int dividend = int.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int divisor = int.Parse(Console.ReadLine());

            bool isDivisible = dividend % divisor == 0;

            if (isDivisible)
            {
                Console.WriteLine($"{dividend} є кратним {divisor}.");
            }
            else
            {
                Console.WriteLine($"{dividend} не є кратним {divisor}.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");
            IsDivisible(); // Виклик методу

        }
    }
}
