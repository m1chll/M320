namespace Lidl
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //var person1 = new Person() {Vorname = "Max", Name = "Mustermann"};
            var kunde1 = new Kunde() {Vorname = "Fritz", Name = "Müller", Umsatz = 1000, Id = 10};
            var lagerist1 = new Lagerist() {Vorname = "Hans", Name = "Meier", Groesse = 180};
            var kind1 = new Kind() { Vorname = "Peterli", Name = "Müller" };

            //person1.Esse();
            kunde1.Esse();
            kunde1.Kaufe();
            lagerist1.Esse();
            lagerist1.LagereEin();
            kunde1.Trage();
            lagerist1.Trage();
            kind1.Esse();
            kind1.Trage();


        }
    }
}