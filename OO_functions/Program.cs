using System.Dynamic;

namespace OO_functions
{
    internal class Program
    {
        static void Main()
        {
            // 1. ggT und kgV berechnen
            Console.WriteLine("1. ggT und kgV berechnen\n");
            int a = MyMath.ReadInt();
            int b = MyMath.ReadInt();
            int ggT = MyMath.Calc_ggT(a, b);
            int kgV = MyMath.Calc_kgV(a, b, ggT);
            MyMath.ShowResult("ggT", a, b, ggT);
            MyMath.ShowResult("kgV", a, b, kgV);


            // 2. ggT rekursiv berechnen
            Console.WriteLine("\n2. ggT rekursiv berechnen");
            ggT = MyMath.Calc_ggT_r(a, b);
            MyMath.ShowResult("ggT", a, b, ggT);


            // 3. arithmetischer Mittelwert, kleinster Wert und grösster Wert eines Arrays berechnen
            Console.WriteLine("\n3. arithmetischer Mittelwert, kleinster Wert und grösster Wert eines Arrays berechnen\n");
            int[] array = MyMath.ReadArray();
            int aritMittelwert = MyMath.AritMittelwert(array);
            Console.WriteLine("Arithmetischer Mittelwert: " + aritMittelwert);

            int klWert = MyMath.KleinsterWert(array);
            Console.WriteLine("Kleinster Wert: " + klWert);

            int grWert = MyMath.GroessterWert(array);
            Console.WriteLine("Groesster Wert: " + grWert);


            // 4. Inhalt von zwei übergebenen Variablen tauschen
            Console.WriteLine("\n4. Inhalt von zwei übergebenen Variablen tauschen\n");
            a = MyMath.ReadInt();
            b = MyMath.ReadInt();
            Console.WriteLine("Vor der Vertauschung: a = {" + a + "}, b = {" + b + "}");
            MyMath.Swap(ref a, ref b);
            Console.WriteLine("Nach der Vertauschung: a = {" + a + "}, b = {" + b + "}");


            // 5. Array umkehren
            Console.WriteLine("\n5. Array umkehren");
            array = MyMath.ReadArray();
            Console.WriteLine("Array vor Umkehrung: ");
            MyMath.ShowArray(array);
            array = MyMath.SwapArray(array);
            Console.WriteLine("Array nach Umkehrung: ");
            MyMath.ShowArray(array);


            // Main Funktion erneut aufrufen
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}