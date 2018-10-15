using System;

namespace KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_powietrzne {
    public class Lotnia : PojazdPowietrzny {
        private int maksymalnaWagaPilota;


        public Lotnia(string rodzajNapedu, int iloscOsobNaPokladzie, bool czyUzywaPaliwo,
            bool czyPosiadaKola, int wysokoscPrzelotowa, int rozpietoscSkrzydel, int maksymalnaWagaPilota) : base(
            rodzajNapedu, iloscOsobNaPokladzie, czyUzywaPaliwo, czyPosiadaKola, wysokoscPrzelotowa,
            rozpietoscSkrzydel) {
            this.maksymalnaWagaPilota = maksymalnaWagaPilota;
        }

        public override void start() {
            Console.Write("rozbieg / pochylanie się w przód");
        }

        public override void stop() {
            Console.Write("wyciąganie nóg / pochylanie się w tył");
        }

        public void przypnijUprzaz() {
            Console.Write("przypinalna/odpinalna uprząż");
        }


        public int MaksymalnaWagaPilota {
            get => maksymalnaWagaPilota;
            set => maksymalnaWagaPilota = value;
        }
    }
}