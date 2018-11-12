using System;
using System.Collections.Generic;
using KatalogPojazdow.Properties.pl.wiktor._abstract;
using KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_ladowe;
using KatalogPojazdow.Properties.pl.wiktor._abstract.pojazdy.pojazdy_ladowe.samochody;

namespace KatalogPojazdow {
    public class FabrykaMercedesow : FabrykaPojazdow {
        public Pojazd stworzPojazd() {
            Console.WriteLine("Witaj w Fabryce Mercedesow:");
                                    Console.WriteLine("Podaj rodzaj nap�du samochodu: ");
                                    string rodzajnapedu = Console.ReadLine();
                                    Console.WriteLine("Podaj iloosobowy jest samochod: ");
                                    int ileOsob = Int32.Parse(Console.ReadLine());
                                    bool paliwo = true;
                                    bool kola = true;
                                    Console.WriteLine("Podaj ilo�� k�:");
                                    int iloscKol = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj pojemno�� silnika: ");
                                    int pojemnoscSilnika = Int32.Parse(Console.ReadLine());
                        
                                    Mercedes nowy = new Mercedes(rodzajnapedu, ileOsob, paliwo, kola, iloscKol, pojemnoscSilnika);
                        
                                    return nowy;
        }
    }
}