using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public class Lagerist : Person
    {
        public int Groesse { get; set; }  
        
        public Lagerist()
        {
            Console.WriteLine("ctor Lagerist");
        } 

        public void LagereEin()
        {
            Console.WriteLine($"Lagerist: {Vorname} {Name} lagert ein.");
        }

        public override void Trage()
        {
            Console.WriteLine($"Lagerist: {Vorname} {Name} {Id} trägt mit Stapler.");
        }
    }
}
