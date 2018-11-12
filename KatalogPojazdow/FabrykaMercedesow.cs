using System;
using System.Collections.Generic;
using KatalogPojazdow.Properties.pl.wiktor._abstract;
using KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_ladowe;
using KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_ladowe.samochody;

namespace KatalogPojazdow {
    public class FabrykaMercedesow : FabrykaPojazdow {
        public Pojazd stworzPojazd() {
            Console.WriteLine("Witaj w Fabryce Mercedesow:");
                                    Console.WriteLine("Podaj rodzaj napêdu samochodu: ");
                                    string rodzajnapedu = Console.ReadLine();
                                    Console.WriteLine("Podaj iloosobowy jest samochod: ");
                                    int ileOsob = Int32.Parse(Console.ReadLine());
                                    bool paliwo = true;
                                    bool kola = true;
                                    Console.WriteLine("Podaj iloœæ kó³:");
                                    int iloscKol = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj pojemnoœæ silnika: ");
                                    int pojemnoscSilnika = Int32.Parse(Console.ReadLine());
                        
                                    Mercedes nowy = new Mercedes(rodzajnapedu, ileOsob, paliwo, kola, iloscKol, pojemnoscSilnika);
                        
                                    return nowy;
        }
    }
}