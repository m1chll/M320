using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungFussballmannschaft;

public class Feldspieler 
{
    public string Name { get; }

    public Feldspieler(string name)
    { 
        Name = name; 
    }
    public void AufsTorSchiessen()
    {
        Console.WriteLine($"{Name} schiesst aufs Tor!");
    }

    public void Graetschen()
    {
        Console.WriteLine($"{Name} macht eine Blutgraetsche!");
    }

    public void Dribbeln()
    {
        Console.WriteLine($"{Name} dribbelt den Gegner schwindlig!");
    }
}

