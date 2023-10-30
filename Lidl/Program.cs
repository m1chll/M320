namespace Lidl
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //var person1 = new Person() {Vorname = "Max", Name = "Mustermann"};
            var kunde1 = new Kunde() {Vorname = "Fritz", Name = "Müller", Umsatz = 1000};
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

            var personen = new List<Person>();
            personen.Add(lagerist1);
            personen.Add(kind1);
            personen.Add(kunde1);

            foreach(var person in personen)
            {
                person.Esse();
            }

            Console.ReadLine();
            Console.ReadLine();


        }
    }
}