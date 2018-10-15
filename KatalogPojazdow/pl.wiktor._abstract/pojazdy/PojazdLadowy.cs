using System;

namespace KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy {
    public class PojazdLadowy : Pojazd {
        private int iloscKol;


        public PojazdLadowy(string rodzajNapedu, int iloscOsobNaPokladzie, bool czyUzywaPaliwo,
            bool czyPosiadaKola, int iloscKol) : base(rodzajNapedu, iloscOsobNaPokladzie, czyUzywaPaliwo,
            czyPosiadaKola) {
            this.iloscKol = iloscKol;
            GdzieSiePorusza = "po l¹dzie";
        }

        public override void start() {
            Console.Write("Poruszaj siê jad¹c!");
        }

        public override void stop() {
            Console.Write("Zatrzymaj siê u¿ywaj¹c hamulca!");
        }


        public int IloscKol {
            get => iloscKol;
            set => iloscKol = value;
        }
    }
}