using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Funktionen
    {
        public static int ReadInt()
        {
            int zahl;
            do
            {
                Console.WriteLine("Bitte geben Sie eine positive Ganzzahl ein: ");
                zahl = Convert.ToInt32(System.Console.ReadLine());

            } while (zahl < 1);

            return zahl;
        }

        public static int ShowResult(int ergebnis)
        {
            System.Console.WriteLine("Das Ergebnis lautet: " + ergebnis);
            return 0;
        }

        public static void Aufforderung()
        {
            Console.WriteLine("Welche Berechnung würden Sie gerne durchführen?");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Beenden");
        }
    }
}
