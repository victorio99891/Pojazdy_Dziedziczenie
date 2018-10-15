using System;

namespace KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_ladowe {
    public class Rower : PojazdLadowy {
        private int wysokoscRamy;


        public Rower(string rodzajNapedu, int iloscOsobNaPokladzie,
            bool czyUzywaPaliwo, bool czyPosiadaKola, int iloscKol, int wysokoscRamy) : base(rodzajNapedu, iloscOsobNaPokladzie, czyUzywaPaliwo, czyPosiadaKola, iloscKol) {
            this.wysokoscRamy = wysokoscRamy;
        }

        public void otworzPodnozke() {
            Console.Write("ma super podnóżkę");
        }


        public override void start() {
            Console.Write("kręcenie pedałami");
        }

        public override void stop() {
            Console.Write("zaciskanie hamulców");
        }


        public int WysokoscRamy {
            get => wysokoscRamy;
            set => wysokoscRamy = value;
        }
    }
}