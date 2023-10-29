using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public class Kind : Person
    {
        public override void Trage()
        {
            Console.WriteLine($"Kind: {Vorname} {Name} sitzt im Einkaufswagen.");
        }

        public override void Esse()
        {
            Console.WriteLine($"Kind: {Vorname} {Name} isst mit den Händen.");
        }
    }
}
