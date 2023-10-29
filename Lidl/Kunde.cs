﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public class Kunde : Person
    {
        public double Umsatz { get; set; }

        public void Kaufe()
        {
            Console.WriteLine($"Kunde: {Vorname} {Name} kauft bei Lidl.");
        }
        public override void Trage()
        {
            Console.WriteLine($"Kunde: {Vorname} {Name} trägt mit Einkaufswagen.");
        }
    }
}
