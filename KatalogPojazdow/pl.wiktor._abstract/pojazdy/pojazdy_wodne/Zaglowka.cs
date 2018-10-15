using System;

namespace KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_wodne {
    public class Zaglowka : PojazdWodny {
        private int wysokoscZagla;

        public Zaglowka(string rodzajNapedu, int iloscOsobNaPokladzie, bool czyUzywaPaliwo, bool czyPosiadaKola,
            int poziomZanurzenia, int wysokoscZagla) : base(rodzajNapedu, iloscOsobNaPokladzie, czyUzywaPaliwo,
            czyPosiadaKola, poziomZanurzenia) {
            this.wysokoscZagla = wysokoscZagla;
        }

        public override void start() {
            Console.Write("podciąganie żagla / pagajowanie");
        }

        public override void stop() {
            Console.Write("ściąganie żagla / wyskoczenie z łódki");
        }

        public void spuscKotwice() {
            Console.Write("spuszczalna kotwica");
        }


        public int WysokoscZagla {
            get => wysokoscZagla;
            set => wysokoscZagla = value;
        }
    }
}