using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Grundrechenoperationen
    {
        private static int letztesErgebnis = 0;

        public static int LetztesErgebnis
        {
            get { return letztesErgebnis; }
            private set { letztesErgebnis = value; }
        }

        public static int Addition(int a, int b, int c)
        {
            int z = Grundrechenoperationen.Parameterwechsel(a, c);
            letztesErgebnis = z + b;
            return letztesErgebnis;
        }

        public static int Subtraktion(int a, int b, int c)
        {
            int z = Grundrechenoperationen.Parameterwechsel(a, c);
            letztesErgebnis = z - b;
            return letztesErgebnis;
        }

        public static int Multiplikation(int a, int b, int c)
        {
            int z = Grundrechenoperationen.Parameterwechsel(a, c);
            letztesErgebnis = z * b;
            return letztesErgebnis;
        }

        public static int Division(int a, int b, int c)
        {
            if (b != 0)
            {
                int z = Grundrechenoperationen.Parameterwechsel(a, c);
                letztesErgebnis = z / b;
                return letztesErgebnis;
            }
            else
            {
                Console.WriteLine("Division durch Null ist nicht erlaubt.");
                return letztesErgebnis;
            }
        }
        public static int Parameterwechsel(int a, int c)
        {
            if (c == 1)
            {
                return letztesErgebnis; 
            }
            return a;
        }
    }
}