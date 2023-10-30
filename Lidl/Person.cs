using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public abstract class Person : Saeugetier
    {
        public string Name {  get; set; }   
        public string Vorname {  get; set; }
        protected int Id { get; set; }
        public Person()
        {
            Console.WriteLine("ctor Person");
        }

        public virtual void Esse()
        {
            Console.WriteLine($"Person: {Vorname} {Name} {Id} isst mit Messer und Gabel.");
        }

        //public virtual void Trage()
        //{
        //    Console.WriteLine($"Person: {Vorname} {Name} trägt mit ...");
        //}

        public abstract void Trage();

        public override void Atme()
        {
            Console.WriteLine("Atme");
        }
    }
}
