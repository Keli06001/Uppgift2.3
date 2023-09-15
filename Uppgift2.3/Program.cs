using System;

namespace Uppgift2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar ska du hyra bilen?");
            string dagarText = Console.ReadLine();
            int dagar=int.Parse(dagarText);
            Console.WriteLine("Hur många kilometer ska du köra?");
            string kilometerText = Console.ReadLine();
            int kilometer = int.Parse(kilometerText);
            int kostnad = 300 + (dagar-1)*500 + (kilometer*1);
            Console.WriteLine(kostnad+"kr");
        }
    }
}