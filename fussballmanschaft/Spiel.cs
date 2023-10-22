using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungFussballmannschaft
{
    public class Spiel
    {
        private Fussballmannschaft Heimmannschaft { get; set; }
        private Fussballmannschaft Auswaertsmannschaft { get; set; }
        public void Spielen()
        {
            CreateTeams();

            Resultat resultat = new Resultat();
            Random random = new Random();

            int teamNummer;

            for (int i = 0; i < random.Next(3, 7); i++)
            {
                teamNummer = random.Next(2);
                if (teamNummer == 0)
                {
                    resultat.ToreHeimmannschaft += Heimmannschaft.Spielzug();
                }
                if (teamNummer == 1)
                {
                    resultat.ToreAuswärtsmannschaft += Auswaertsmannschaft.Spielzug();
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{Heimmannschaft.Name} {resultat.ToreHeimmannschaft} : {resultat.ToreAuswärtsmannschaft} {Auswaertsmannschaft.Name}");
        }
        public void CreateTeams()
        {
            // FC St.Gallen
            Heimmannschaft = new Fussballmannschaft("Fc St.Gallen");

            Torwart Zigi = new Torwart("Zigi");
            Heimmannschaft.SetTorwart(Zigi);  

            Feldspieler Sutter = new Feldspieler("Sutter");
            Heimmannschaft.AddSpieler(Sutter);

            Feldspieler Quintilla = new Feldspieler("Quintilla");
            Heimmannschaft.AddSpieler(Quintilla);

            Feldspieler vonMoos = new Feldspieler("vonMoos");
            Heimmannschaft.AddSpieler(vonMoos);

            Feldspieler Moeller = new Feldspieler("Moeller");
            Heimmannschaft.AddSpieler(Moeller);

            Feldspieler Vallci = new Feldspieler("Vallci");
            Heimmannschaft.AddSpieler(Vallci);

            Feldspieler Fazliji = new Feldspieler("Fazliji");
            Heimmannschaft.AddSpieler(Fazliji);

            Feldspieler Toma = new Feldspieler("Toma");
            Heimmannschaft.AddSpieler(Toma);

            Feldspieler Schmidt = new Feldspieler("Schmidt");
            Heimmannschaft.AddSpieler(Schmidt);

            Feldspieler Okoroji = new Feldspieler("Okoroji");
            Heimmannschaft.AddSpieler(Okoroji);

            Feldspieler Witzig = new Feldspieler("Witzig");
            Heimmannschaft.AddSpieler(Witzig);


            // FC Stade Lausanne Ouchy
            Auswaertsmannschaft = new Fussballmannschaft("FC Stade Lausanne Ouchy");

            Torwart DaSilva = new Torwart("DaSilva");
            Auswaertsmannschaft.SetTorwart(DaSilva);

            Feldspieler Hajrulahu = new Feldspieler("Hajrulahu");
            Auswaertsmannschaft.AddSpieler(Hajrulahu);

            Feldspieler Bayard = new Feldspieler("Bayard");
            Auswaertsmannschaft.AddSpieler(Bayard);

            Feldspieler Qarri = new Feldspieler("Qarri");
            Auswaertsmannschaft.AddSpieler(Qarri);

            Feldspieler Gharbi = new Feldspieler("Gharbi");
            Auswaertsmannschaft.AddSpieler(Gharbi);

            Feldspieler Ajdini = new Feldspieler("Ajdini");
            Auswaertsmannschaft.AddSpieler(Ajdini);

            Feldspieler Obexer = new Feldspieler("Obexer");
            Auswaertsmannschaft.AddSpieler(Obexer);

            Feldspieler Gassama = new Feldspieler("Gassama");
            Auswaertsmannschaft.AddSpieler(Gassama);

            Feldspieler Mahmoud = new Feldspieler("Mahmoud");
            Auswaertsmannschaft.AddSpieler(Mahmoud);

            Feldspieler Camara = new Feldspieler("Camara");
            Auswaertsmannschaft.AddSpieler(Camara);

            Feldspieler Hamdiu = new Feldspieler("Hamdiu");
            Auswaertsmannschaft.AddSpieler(Hamdiu);
        }
    }
}
