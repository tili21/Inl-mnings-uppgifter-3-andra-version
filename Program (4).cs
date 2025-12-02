using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är låten (minuter)?");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många sekunder?");
            int sek = int.Parse(Console.ReadLine());

            int totalSek = min * 60 + sek;

            int minTillåtet = 2 * 60 + 45; // 165 sek
            int maxTillåtet = 4 * 60 + 20; // 260 sek

            if (totalSek >= minTillåtet && totalSek <= maxTillåtet)
            {
                Console.WriteLine("Låten får spelas på radiostationen.");
            }
            else
            {
                Console.WriteLine("Låten får inte spelas.");
            }
        }
    }
}
