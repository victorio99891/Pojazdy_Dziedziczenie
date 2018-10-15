using System;

namespace KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_wodne {
    public class StatekPodwodny : PojazdWodny {
        private int maksymalnaGlebokosc;

        public StatekPodwodny(string rodzajNapedu, int iloscOsobNaPokladzie, bool czyUzywaPaliwo, bool czyPosiadaKola,
            int poziomZanurzenia, int maksymalnaGlebokosc) : base(rodzajNapedu, iloscOsobNaPokladzie, czyUzywaPaliwo,
            czyPosiadaKola, poziomZanurzenia) {
            this.maksymalnaGlebokosc = maksymalnaGlebokosc;
        }

        public void zanurzSie() {
            Console.Write("możliwość zanurzenia");
        }

        public override void start() {
            Console.Write("wajha w przód");
        }

        public override void stop() {
            Console.Write("wajha w tył");
        }

        public int MaksymalnaGlebokosc {
            get => maksymalnaGlebokosc;
            set => maksymalnaGlebokosc = value;
        }
    }
}