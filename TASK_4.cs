using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB11
{
    internal class Program
    {
        static string TranslateSeason(string seasonUa)
        {
            switch (seasonUa.ToLower())
            {
                case "зима":
                    return "Winter";
                case "весна":
                    return "Spring";
                case "літо":
                    return "Summer";
                case "осінь":
                    return "Autumn";
                default:
                    return "Невідомий сезон";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");
            Console.Write("Введіть назву пори року українською мовою: ");
            string seasonUa = Console.ReadLine();

            string seasonEn = TranslateSeason(seasonUa);
            Console.WriteLine($"Англійською мовою це: {seasonEn}");
        }
    }
}
