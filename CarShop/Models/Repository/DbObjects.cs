using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShop.Models.Repository
{
    public class DbObjects
    {
        public List<Product> DefProducts
        {
            get
            {
                return new List<Product>
                {
                    //akumulator
                    new Product
                    {
                        Name = "Akumulator CENTRA AGM CK600",
                        Description = "Napięcie [V]: 12, Pojemność akumulatora [Ah]: 60, Wysokość [mm]: 190, Szerokość [mm]: 175, Długość [mm]: 242, Prąd rozruchu wg EN [A]: 680, Wykonanie strefy podłogowej: B13",
                        Category = "Akumulator",
                        Price = 542
                    },
                    new Product
                    {
                        Name = "Akumulator BANNER 56001",
                        Description = "Napięcie [V]: 12, Pojemność akumulatora [Ah]: 60, Wysokość [mm]: 190, Szerokość [mm]: 175, Długość [mm]: 242, Prąd rozruchu wg EN [A]: 680, Wykonanie strefy podłogowej: B13",
                        Category = "Akumulator",
                        Price = 399
                    },
                    new Product
                    {
                        Name = "Akumulator JENOX 074624",
                        Description = "Napięcie [V]: 12, Pojemność akumulatora [Ah]: 74, Prąd rozruchu wg EN [A]: 680, Długość [mm]: 278, Szerokość [mm]: 175, Wysokość [mm]: 190, Wykonanie strefy podłogowej: B13",
                        Category = "Akumulator",
                        Price = 499
                    },
                    //Olej silnikowy
                    new Product
                    {
                        Name = "Olej silnikowy MOTUL 6100 Synergie 15W50 1 litr",
                        Description = "Producent: MOTUL, Seria: 6100, Lepkość wg SAE: 15W50",
                        Category = "Olej silnikowy",
                        Price = 28
                    },
                    new Product
                    {
                        Name = "Olej silnikowy MOTUL 4100 Turbolight 10W40 1 litr",
                        Description = "Producent: MOTUL, Seria: 4100, Lepkość wg SAE: 10W40",
                        Category = "Olej silnikowy",
                        Price = 27
                    },
                    new Product
                    {
                        Name = "Olej SHELL Helix HX7 Diesel 10W40 1 litr",
                        Description = "Producent: SHELL, Seria: Helix, Lepkość wg SAE: 10W40.",
                        Category = "Olej silnikowy",
                        Price = 23
                    },
                    new Product
                    {
                        Name = "Olej SHELL Helix HX3 15W40 1 litr",
                        Description = "Producent: SHELL, Seria: Helix, Lepkość wg SAE: 15W40.",
                        Category = "Olej silnikowy",
                        Price = 17
                    },
                    //Świeca zapłonowa
                    new Product
                    {
                        Name = "Świeca zapłonowa CHAMPION OE223",
                        Description = "Wymiar gwintu: M14x1.25, Rozmiar klucza: 16 mm, Długość gwintu [mm]: 19, Opornożć od [kOhm]: 3, Opór do [kOhm]: 9, Wysięg [mm]: 3,6",
                        Category = "Świeca zapłonowa",
                        Price = 23
                    },
                    new Product
                    {
                        Name = "Świeca zapłonowa NGK V-Line 3045",
                        Description = "Rozmiar klucza: 16 mm, Gwint zewn. [mm]: 14,0, Długość gwintu [mm]: 19,0, Położenie elektrod [mm]: 5,2, Odkłócony, 1 kOhm",
                        Category = "Świeca zapłonowa",
                        Price = 24
                    },
                    new Product
                    {
                        Name = "Świeca zapłonowa DENSO IK16",
                        Description = "Rozmiar klucza: 16 mm, Gwint zewn. [mm]: 14,0, Długość gwintu [mm]: 19,0, Moment dokrecenia [Nm]: 22",
                        Category = "Świeca zapłonowa",
                        Price = 46
                    },
                    //Narzędzia warsztatowe
                    new Product
                    {
                        Name = "Zestaw narzędziowy 1/4'', 3/8'' 73 SZT.",
                        Description = "Podstawowy zestaw narzędziowy Top Tools jest przeznaczony do wszystkich najpopularniejszych prac w domu. Składa się z 73 elementów w rozmiarach ¼” oraz 3/8”. Zestaw zawiera pełen pakiet nasadek sześciokątnych w dwóch rozmiarach, grzechotkę oraz akcesoria, dzięki czemu jest możliwe przeprowadzenie większości prac mechanicznych. Wszechstronność kompletu podkreśla obecność kluczy płasko-oczkowych, młotka stolarskiego, kluczy sześciokątnych, wkrętaków. Narzędzia są umieszczone w wygodnej i solidnej walizce z tworzywa sztucznego.",
                        Category = "Narzędzia warsztatowe",
                        Price = 140
                    },
                    new Product
                    {
                        Name = "Zestaw narzędziowy 1 4” 20 części",
                        Description = "nasadki 1/4”: 3.5; 4; 4.5; 5; 5.5; 6; 7; 8; 9; 10; 11; 12; 13; 14 mm, L = 25 mm; " +
                        "przedłużki 1 / 4”: 50,8 mm; 152,4 mm; " +
                        "grzechotka 1 / 4”, 72T, L= 155 mm; " +
                        "pokrętło wkrętakowe 1 / 4”, L= 150 mm; " +
                        "pokrętło przesuwne 1 / 4”, L= 152,4 mm; " +
                        "przegub Cardana 1 / 4”; " +
                        "walizka",
                        Category = "Narzędzia warsztatowe",
                        Price = 68
                    },
                    new Product
                    {
                        Name = "Zestaw narzędziowy 1 4” 38 sztuk",
                        Description = "Grzechotka 1/4”” (72 zęby); Wkrętak 1/4”” 150 mm; Przegub Cardana 1/4”; Przedłużki 50,8 i 101,6 mm; Pokrętło przesuwne 152,4 mm; Nasadki (25mm) 3.5, 4, 4.5, 5, 5.5, 6, 7, 8, 9, 10, 11, 12, 13, 14 mm; Bity imbusowe 3, 4, 5, 6, 8 mm; Bity TORX T8, T10, T15, T20, T25, T30, T40; AISI S2/CrV50BV30; Bity krzyżowe philips PH1, PH2,; Bity krzyżowe pozidrive PZ1, PZ2,; Bity płaskie 4, 5.5, 6.5 mm; Walizka", 
                        Category = "Narzędzia warsztatowe",
                        Price = 121
                    },
                    new Product
                    {
                        Name = "Zestaw narzędziowy 1 2” 120 części xl",
                        Description = "Specjalistyczny zestaw narzędziowy, który został przygotowany pod kątem potrzeb wyspecjalizowanych serwisów samochodowych i mechanicznych. Klucze nasadowe, jak i napęd nasadek, zostały zrobione zodpornej, narzędziowej stali. Nasadki wyproduktowano metodą kucia matrycowego, a przed procesem hartowania poddano je kalibracji przy wykorzystaniu precyzyjnych przymiarów i urządzeń kontrolnych. Nasadki wyposażone w system AS-Drive, podwyższającymaksymalny moment o 25%, przy pełnej oochraniae obrzeży nakrętek, nasadki z dwutonowym wykończeniem powierzchni. W skład zestawu wchodzą takżebity zrobione ztwardej stali S2. Zestaw pozwala na pracę wymagającą bardzo dużych obciążeń i precyzji, pozwala wykonywać wiele czynności serwisowych związanych z odkręcaniem i przykręcaniem połączeń gwintowych o różnych rozmiarach nominalnych. Grzechotki zawierają trójkomponentową rękojeść oraz 72 zęby (skok roboczy 5 stopni).",
                        Category = "Narzędzia warsztatowe",
                        Price = 121
                    },
                    new Product
                    {
                        Name = "Podnośnik hydrauliczny słupkowy 3t",
                        Description = "Specjalistyczny podnośnik hydrauliczny słupkowy marki YATO, zawierający system zaworów, które precyzyjnie dawkują strugę oleju. Udźwig podnośnika wynosi 3 tony, a zakres podnoszenia wynosi od 194 mm do 374 mm. Charakteryzuje się niewielkim rozmiarem i ciężarem, co ma istotne znaczenie w przemieszczaniu i przechowywaniu. Niezbędny w warsztatach samochodowych i stacjach obsługi pojazdów.",
                        Category = "Narzędzia warsztatowe",
                        Price = 77
                    },
                    new Product
                    {
                        Name = "Podnośnik hydrauliczny słupkowy 8t",
                        Description = "Specjalistyczny podnośnik hydrauliczny słupkowy marki YATO, zawierający system zaworów, które precyzyjnie dawkują strugę oleju. Udźwig podnośnika wynosi 8 ton, a zakres podnoszenia wynosi od 230 mm do 457 mm. Charakteryzuje się niewielkim rozmiarem i ciężarem, co ma istotne znaczenie w przemieszczaniu i przechowywaniu. Niezbędny w warsztatach samochodowych i stacjach obsługi pojazdów.",
                        Category = "Narzędzia warsztatowe",
                        Price = 130
                    },
                    new Product
                    {
                        Name = "Podstawka pod samochód 2t",
                        Description = "Producent: REXXER; Podstawka pod samochód 2t",
                        Category = "Narzędzia warsztatowe",
                        Price = 178
                    },
                };
            }
        }

    }
}