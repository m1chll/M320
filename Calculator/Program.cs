using System.Linq.Expressions;

namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            while(true) 
            { 
                // Deklaration
                int berechnungsart;
                int ergebnis = 0;
                int parameteranzahl;
                int a = 0;
                int b = 0;

                do
                {
                    Funktionen.Aufforderung();
                    berechnungsart = Convert.ToInt32(System.Console.ReadLine());
                } while (berechnungsart < 1 || berechnungsart > 5);

                // Programm beenden
                if (berechnungsart == 5)
                {
                    Environment.Exit(0); 
                }

                do
                {
                    System.Console.WriteLine($"Möchen Sie die Berechnung mit einem oder zwei Parametern durchführen?" +
                        $"\n 1. ein Parameter" +
                        $"\n 2. zwei Paramater");
                    parameteranzahl = Convert.ToInt32(System.Console.ReadLine());
                } while (parameteranzahl != 1 && parameteranzahl != 2);

                if(parameteranzahl != 1)
                {
                    a = Funktionen.ReadInt();
                }
                b = Funktionen.ReadInt();

                switch (berechnungsart)
                {
                    case 1:
                        ergebnis = Grundrechenoperationen.Addition(a, b, parameteranzahl);
                        break;
                    case 2:
                        ergebnis = Grundrechenoperationen.Subtraktion(a, b, parameteranzahl);
                        break;
                    case 3:
                        ergebnis = Grundrechenoperationen.Multiplikation(a, b, parameteranzahl);
                        break;
                    case 4:
                        ergebnis = Grundrechenoperationen.Division(a, b, parameteranzahl);
                        break;
                }

                Funktionen.ShowResult(ergebnis);
            }
        }
    }
}
