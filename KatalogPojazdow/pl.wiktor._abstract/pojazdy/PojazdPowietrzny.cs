using System;

namespace KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy {
    public abstract class PojazdPowietrzny : Pojazd {
        private int wysokoscPrzelotowa;
        private int rozpietoscSkrzydel;

        public PojazdPowietrzny(string rodzajNapedu, int iloscOsobNaPokladzie, bool czyUzywaPaliwo,
            bool czyPosiadaKola, int wysokoscPrzelotowa, int rozpietoscSkrzydel) : base(rodzajNapedu,
            iloscOsobNaPokladzie, czyUzywaPaliwo, czyPosiadaKola) {
            this.wysokoscPrzelotowa = wysokoscPrzelotowa;
            this.rozpietoscSkrzydel = rozpietoscSkrzydel;
            GdzieSiePorusza = "w powietrzu";
        }

        public override void start() {
            Console.WriteLine("Mo�e lata�");
        }

        public override void stop() {
            Console.WriteLine("Mo�e wyl�dow��");
        }


        public int WysokoscPrzelotowa {
            get => wysokoscPrzelotowa;
            set => wysokoscPrzelotowa = value;
        }

        public int RozpietoscSkrzydel {
            get => rozpietoscSkrzydel;
            set => rozpietoscSkrzydel = value;
        }
    }
}