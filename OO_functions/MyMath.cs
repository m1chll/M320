using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OO_functions
{
    public static class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            int z = a;
            while(b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }

        public static int Calc_kgV(int a, int b, int ggT) 
        { 
            int z = a * b / ggT;
            return z;
        }

        public static int ReadInt()
        {
            int zahl;
            do
            {
                Console.WriteLine("Bitte geben Sie eine positive Ganzzahl ein: ");
                zahl = Convert.ToInt32(Console.ReadLine());

            } while (zahl < 1);

            return zahl;
        }

        public static int ShowResult(string arit, int a, int b, int zahl)
        {
            Console.WriteLine(arit + " von " + a + " und " + b + " ist " + zahl);
            return 0;
        }

        public static int[] ReadArray()
        {
            Console.WriteLine("Wie viele Zahlen soll Ihr Array haben?");
            int laenge = MyMath.ReadInt();
            int[] array = new int[laenge];
            for (int i = 0; i < laenge; i++)
            {
                array[i] = MyMath.ReadInt();
            }
            return array;
        }
        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return Calc_ggT_r(b, a % b);
            }
        }


        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);

                if (i < array.Length - 1)
                {
                    Console.Write(", "); 
                }
            }
            Console.WriteLine();
        }

        public static int AritMittelwert(int[] array)
        {
            int summe = 0;
            foreach(int zahl in array)
            {
                summe += zahl;
            }
            return summe / array.Length;
        }

        public static int KleinsterWert(int[] array)
        {
            int kleinsteZahl = array[0];
            foreach (int zahl in array)
            {
                if(zahl < kleinsteZahl)
                {
                    kleinsteZahl = zahl;
                }
            }
            return kleinsteZahl;
        }

        public static int GroessterWert(int[] array)
        {
            int groessteZahl = 0;
            foreach (int zahl in array)
            {
                if (zahl > groessteZahl)
                {
                    groessteZahl = zahl;
                }
            }
            return groessteZahl;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int[] SwapArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[array.Length - 1 - i] = array[i];
            }
            return newArray;
        }

    }
}
