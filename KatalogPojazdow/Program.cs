using System;
using System.Collections.Generic;
using System.IO;
using KatalogPojazdow.Properties.pl.wiktor._abstract;
using KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy;
using KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_ladowe;
using KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_ladowe.samochody;
using KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_powietrzne;
using KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_wodne;

namespace KatalogPojazdow {
    internal class Program {
        static List<Pojazd> pojazdy = new List<Pojazd>();
<<<<<<< HEAD
        private static FabrykaPojazdow fabrykaPojazdow;
        static DelegatTworzenia delegatTworzenia;
=======
        private static FabrykaPojazdow fabryka;
>>>>>>> a81982d66b2d884c8da96046922a06e28cb62f7c

        public static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            pojazdy.Clear();
            pojazdy.Add(new Rower("siła mięśni", 1, false, true, 2, 54));
            pojazdy.Add(new Samochod("silnik benzynowy", 5, true, true, 4, 5));
            pojazdy.Add(new Audi("silnik diesel", 2, true, true, 4, 6));
            pojazdy.Add(new Mercedes("silnik benzynowy turbo", 5, true, true, 4, 8));
            pojazdy.Add(new Lotnia("podmuch powietrza", 1, false, true, 300, 10, 150));
            pojazdy.Add(new Samolot("silnik odrzutowy", 250, true, true, 10000, 45, 4));
            pojazdy.Add(new Zaglowka("na wiatr", 8, false, false, 1, 15));
            pojazdy.Add(new StatekPodwodny("silnik diesel", 20, true, false, 2, 1500));

            Console.Clear();

            drukujMenu();
            obslugaProgramu();
        }


        private static void obslugaProgramu() {
            int input = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (input) {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nWSZYSTKIE POJAZDY:\n");
                    drukujPojazd(pojazdy);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nPOJAZDY LĄDOWE:\n");
                    drukujPojazd(filtrowanieRodzajowPojazdow(pojazdy, 2));
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nPOJAZDY WODNE:\n");
                    drukujPojazd(filtrowanieRodzajowPojazdow(pojazdy, 3));
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPOJAZDY POWIETRZNE:\n");
                    drukujPojazd(filtrowanieRodzajowPojazdow(pojazdy, 4));
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("\nWYBIERZ JAKIE POJAZDY CHCESZ ZOBACZYĆ\n");
                    Console.WriteLine("1 - Pojazdy używające paliwo");
                    Console.WriteLine("2 - Pojazdy nie używające paliwa");
                    Console.WriteLine("3 - Pojazdy z kołami");
                    Console.WriteLine("4 - Pojazdy bez kół");
                    int input2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (input2) {
                        case 1:
                            Console.WriteLine("\nPOJAZDY UŻYWAJĄCE PALIWO:\n");
                            drukujPojazd(filtrPojazdowPaliwo(pojazdy, 1));
                            break;
                        case 2:
                            Console.WriteLine("\nPOJAZDY NIE UŻYWAJĄCE PALIWA:\n");
                            drukujPojazd(filtrPojazdowPaliwo(pojazdy, 2));
                            break;
                        case 3:
                            Console.WriteLine("\nPOJAZDY MAJĄCE KOŁA:\n");
                            drukujPojazd(filtrPojazdowPaliwo(pojazdy, 3));
                            break;
                        case 4:
                            Console.WriteLine("\nPOJAZDY NIE MAJĄCE KÓŁ:\n");
                            drukujPojazd(filtrPojazdowPaliwo(pojazdy, 4));
                            break;
                    }

                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nDOSTEPNE MARKI SAMOCHODOW:\n");
                    drukujPojazd(filtrowanieRodzajowPojazdow(pojazdy, 5));
                    break;

                case 10:
<<<<<<< HEAD
                    fabrykaPojazdow = new FabrykaMercedesow(pojazdy);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    delegatTworzenia = new DelegatTworzenia();
                    delegatTworzenia.FabrykaDelegat -= delegatTworzenia.drukujStopke;
                    delegatTworzenia.FabrykaDelegat += fabrykaPojazdow.stworzPojazd;
                    delegatTworzenia.FabrykaDelegat += delegatTworzenia.drukujStopke;
                    delegatTworzenia.FabrykaDelegat();
                    Console.WriteLine("Stworzno nowego Mercedesa!");
                    break;
                case 11:
                    fabrykaPojazdow = new FabrykaAudi(pojazdy);
                    Console.ForegroundColor = ConsoleColor.Green;
                    delegatTworzenia = new DelegatTworzenia();
                    delegatTworzenia.FabrykaDelegat -= delegatTworzenia.drukujStopke;
                    delegatTworzenia.FabrykaDelegat += fabrykaPojazdow.stworzPojazd;
                    delegatTworzenia.FabrykaDelegat += delegatTworzenia.drukujStopke;
                    delegatTworzenia.FabrykaDelegat();
=======
                    fabryka = new FabrykaMercedesow();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    pojazdy.Add(fabryka.stworzPojazd());
                    Console.WriteLine("Stworzno nowego Mercedesa!");
                    break;
                case 11:
                    fabryka = new FabrykaAudi();
                    Console.ForegroundColor = ConsoleColor.Green;
                    pojazdy.Add(fabryka.stworzPojazd());
>>>>>>> a81982d66b2d884c8da96046922a06e28cb62f7c
                    Console.WriteLine("Stworzno nowego Audi!");
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            drukujMenu();
            obslugaProgramu();
        }


        private static void drukujMenu() {
            Console.WriteLine("Witaj w katalogu pojazdów! Co chcesz zrobić?");
            Console.WriteLine("1 - Pokaż wszystkie pojazdy");
            Console.WriteLine("2 - Pokaz pojazdy lądowe");
            Console.WriteLine("3 - Pokaz pojazdy wodne");
            Console.WriteLine("4 - Pokaz pojazdy powietrzne");
            Console.WriteLine("5 - Pokaz więcej szczegółów");
            Console.WriteLine("8 - Pokaz dostepne marki samochodow");
            Console.WriteLine("10 - Stwórz nowego Mercedesa");
            Console.WriteLine("11 - Stwórz nowe Audi");
            Console.WriteLine("9 - Wyjdź z apliakcji");
        }

        private static List<Pojazd> filtrowanieRodzajowPojazdow(List<Pojazd> pojazdy, int opcja) {
            List<Pojazd> tmp = new List<Pojazd>();
            if (opcja == 2) {
                foreach (var pojazd in pojazdy) {
                    if ((pojazd is PojazdLadowy) && !(pojazd is Audi) && !(pojazd is Mercedes)) {
                        tmp.Add(pojazd);
                    }
                }

                return tmp;
            }

            if (opcja == 3) {
                foreach (var pojazd in pojazdy) {
                    if (pojazd is PojazdWodny) {
                        tmp.Add(pojazd);
                    }
                }

                return tmp;
            }

            if (opcja == 4) {
                foreach (var pojazd in pojazdy) {
                    if (pojazd is PojazdPowietrzny) {
                        tmp.Add(pojazd);
                    }
                }

                return tmp;
            }

            if (opcja == 5) {
                foreach (var pojazd in pojazdy) {
                    if (pojazd is Mercedes || pojazd is Audi) {
                        tmp.Add(pojazd);
                    }
                }
            }

            return tmp;
        }

        private static List<Pojazd> filtrPojazdowPaliwo(List<Pojazd> pojazdy, int opcja) {
            List<Pojazd> tmp = new List<Pojazd>();
            tmp.Clear();

            if (opcja == 1) {
                foreach (var pojazd in pojazdy) {
                    if (pojazd.CzyUzywaPaliwo) {
                        tmp.Add(pojazd);
                    }
                }

                return tmp;
            }

            if (opcja == 2) {
                foreach (var pojazd in pojazdy) {
                    if (!pojazd.CzyUzywaPaliwo) {
                        tmp.Add(pojazd);
                    }
                }

                return tmp;
            }

            if (opcja == 3) {
                foreach (var pojazd in pojazdy) {
                    if (pojazd.CzyPosiadaKola) {
                        tmp.Add(pojazd);
                    }
                }

                return tmp;
            }

            if (opcja == 4) {
                foreach (var pojazd in pojazdy) {
                    if (!pojazd.CzyPosiadaKola) {
                        tmp.Add(pojazd);
                    }
                }

                return tmp;
            }


            return tmp;
        }

        private static void drukujPojazd(List<Pojazd> pojazdy) {
            foreach (var pojazd in pojazdy) {
                Console.WriteLine(
                    " ======================================================================================================= ");
                Console.WriteLine("|               \"" + pojazd.GetType().Name + "\" to dziecko \"" +
                                  pojazd.GetType().BaseType.Name + "\" co jest dzieckiem \"" +
                                  pojazd.GetType().BaseType.BaseType.Name + "\"");
                Console.WriteLine(
                    " ======================================================================================================= ");
                Console.WriteLine("|          Poruszanie się: " + pojazd.GdzieSiePorusza);
                Console.Write("|          Przyspieszanie: ");
                pojazd.start();
                Console.WriteLine();
                Console.Write("|              Zwalnianie: ");
                pojazd.stop();
                Console.WriteLine();
                Console.WriteLine("| Ilość osób na pokładzie: " + pojazd.IloscOsobNaPokladzie);
                Console.WriteLine("|           Rodzaj napędu: " + pojazd.RodzajNapedu);
                Console.WriteLine("|         Spalanie paliwa: " + zamienBoolNaString(pojazd.CzyUzywaPaliwo));
                Console.WriteLine("|            Posiada koła: " + zamienBoolNaString(pojazd.CzyPosiadaKola));
                Console.WriteLine("|    Dodatkowe informacje: ");
                pokazDodatkoweOpcje(pojazd);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private static void pokazDodatkoweOpcje(Pojazd pojazd) {
            if (pojazd is PojazdLadowy) {
                PojazdLadowy poj = (PojazdLadowy) pojazd;
                Console.WriteLine("|                           - pojazd ten ma " + poj.IloscKol + " koła");
            }

            if (pojazd is PojazdWodny) {
                PojazdWodny poj = (PojazdWodny) pojazd;
                Console.WriteLine("|                           - pojazd ten ma " + poj.PoziomZanurzenia +
                                  " m zanurzenia");
            }

            if (pojazd is PojazdPowietrzny) {
                PojazdPowietrzny poj = (PojazdPowietrzny) pojazd;
                Console.WriteLine("|                           - wysokość przelotowa to " + poj.WysokoscPrzelotowa +
                                  " m");
                Console.WriteLine("|                           - rozpiętość skrzydeł to " + poj.RozpietoscSkrzydel +
                                  " m");
            }

            if (pojazd is Rower) {
                Rower row = (Rower) pojazd;
                Console.Write("|                           - ");
                row.otworzPodnozke();
                Console.WriteLine();
                Console.WriteLine("|                           - wysokość ramy to " + row.WysokoscRamy + " cm ");
            }


            if (pojazd is Samochod) {
                Samochod sam = (Samochod) pojazd;
                Console.Write("|                           - ");
                sam.otworzSzybe();
                Console.WriteLine();
                Console.WriteLine("|                           - pojemność silnika to " + sam.PojemnoscSilnika +
                                  " litrów ");

                Console.Write("|                           ");
                sam.pokazDodatkoweMozliwosciSamochodu();
            }

            if (pojazd is StatekPodwodny) {
                StatekPodwodny sta = (StatekPodwodny) pojazd;
                Console.Write("|                           - ");
                sta.zanurzSie();
                Console.WriteLine();
                Console.WriteLine("|                           - maksymalne zanurzenie to " +
                                  sta.MaksymalnaGlebokosc +
                                  "m ");
            }

            if (pojazd is Zaglowka) {
                Zaglowka zag = (Zaglowka) pojazd;
                Console.Write("|                           - ");
                zag.spuscKotwice();
                Console.WriteLine();
                Console.WriteLine("|                           - wysokość żagla to " + zag.WysokoscZagla + "m ");
            }

            if (pojazd is Lotnia) {
                Lotnia lot = (Lotnia) pojazd;
                Console.Write("|                           - ");
                lot.przypnijUprzaz();
                Console.WriteLine();
                Console.WriteLine("|                           - maksymalna waga pilota to " +
                                  lot.MaksymalnaWagaPilota + "kg ");
            }

            if (pojazd is Samolot) {
                Samolot lot = (Samolot) pojazd;
                Console.Write("|                           - ");
                lot.wlaczAutopilot();
                Console.WriteLine();
                Console.WriteLine("|                           - samolot posiada " + lot.IloscSilnikow +
                                  " silniki/ów ");
            }
        }

        private static string zamienBoolNaString(bool zmienna) {
            if (zmienna) {
                return "tak";
            }

            return "nie";
        }
    }
}