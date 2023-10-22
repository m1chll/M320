using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungFussballmannschaft;

public class Torwart
{
    public string Name { get; }

    public Torwart(string name)
    {
        Name = name;
    }
    public void SchussHalten()
    {
        Console.WriteLine($"{Name} hält den Schuss vom Gegner");
    }

    public void Abstoss()
    {
        Console.WriteLine($"{Name} macht einen Abstoss");
    }
}

