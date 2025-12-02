using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in första talet:");
            int tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in andra talet:");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Välj ett räknesätt:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            string val = Console.ReadLine();

            if (val == "1")
            {
                Console.WriteLine($"Resultat: {tal1 + tal2}");
            }
            else if (val == "2")
            {
                Console.WriteLine($"Resultat: {tal1 - tal2}");
            }
            else if (val == "3")
            {
                Console.WriteLine($"Resultat: {tal1 * tal2}");
            }
            else if (val == "4")
            {
                Console.WriteLine($"Resultat: {tal1 / tal2}");
            }
            else
            {
                Console.WriteLine("Fel val.");
            }
        }
    }
}
