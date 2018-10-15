using System;

namespace KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_powietrzne {
    public class Samolot : PojazdPowietrzny {
        private int iloscSilnikow;

        public Samolot(string rodzajNapedu, int iloscOsobNaPokladzie, bool czyUzywaPaliwo,
            bool czyPosiadaKola, int wysokoscPrzelotowa, int rozpietoscSkrzydel, int iloscSilnikow) : base(
            rodzajNapedu, iloscOsobNaPokladzie, czyUzywaPaliwo, czyPosiadaKola, wysokoscPrzelotowa,
            rozpietoscSkrzydel) {
            this.iloscSilnikow = iloscSilnikow;
        }

        public override void start() {
            Console.Write("pchnij drążek od siebie");
        }

        public override void stop() {
            Console.Write("ciągnij drążek do siebie");
        }


        public void wlaczAutopilot() {
            Console.Write("używanie autopilota");
        }


        public int IloscSilnikow {
            get => iloscSilnikow;
            set => iloscSilnikow = value;
        }
    }
}