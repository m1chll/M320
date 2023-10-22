    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace UebungFussballmannschaft;

    public class Fussballmannschaft
    {
        public string Name { get; }
        private List<Feldspieler> Spielerliste { get; set; } = new List<Feldspieler>();
        public Torwart Torwart { get; set; }
        public int Tore { get; set; }   
    

        private int spieler;
        private int SpielzugArt;
        private bool _aufsTorSchiessen;
        private bool _graetschen;
        private bool _dribbeln;
        private bool _schussHalten;
        private bool _abstoss;

        public Fussballmannschaft(string name)
        {
            Name = name;
        }

        public void AddSpieler(Feldspieler feldspieler)
        {
            Spielerliste.Add(feldspieler);
        }

        public void SetTorwart(Torwart torwart)
        {
            Torwart = torwart;
        }

        public int Spielzug()
        {
            Random random = new Random();


            while (_schussHalten == false || _abstoss == false || _aufsTorSchiessen == false || _graetschen == false && _dribbeln == false)
            {
                int spielerNummer = random.Next(11);
                int SpielzugArt = random.Next(1, 4);

                if (SpielzugArt == 1 && spielerNummer == 10)
                {
                    Torwart.SchussHalten();
                    _schussHalten = true;
                }
                else if (SpielzugArt == 2 && spielerNummer == 10)
                {
                    Torwart.Abstoss();
                    _abstoss = true;
                }
                else if (spielerNummer == 11)
                {

                }
                else if (SpielzugArt == 1 && spielerNummer != 10)
                {
                    Feldspieler spieler = Spielerliste[spielerNummer];
                    spieler.AufsTorSchiessen();
                    _aufsTorSchiessen = true;
                }
                else if (SpielzugArt == 2 && spielerNummer != 10)
                {
                    Feldspieler spieler = Spielerliste[spielerNummer];
                    spieler.Graetschen();
                    _graetschen = true;
                }
                else if (SpielzugArt == 3 && spielerNummer != 10)
                {
                    Feldspieler spieler = Spielerliste[spielerNummer];
                    spieler.Dribbeln();
                    _dribbeln = true;
                }
            }
            return random.Next(3);
        }
    }