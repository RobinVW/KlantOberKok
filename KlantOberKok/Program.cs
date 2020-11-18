using BusinessLayer;
using System;

namespace KlantOberKok
{
    class Program
    {
        static void Main(string[] args)
        {
            var klant1 = new Klant("Piet");
            var klant2 = new Klant("Jef");
            var bestellingsSysteem = new BestellingsSysteem();
            var bel = new Bel();
            var ober = new Ober("Jan")
            {
                BestellingsSysteem = bestellingsSysteem,
                Bel = bel,
            };
            // kok en ober weten niet van elkaar!
            var kok = new Kok("Marie")
            {
                BestellingsSysteem = bestellingsSysteem,
                Bel = bel,
            };

            klant1.Bestel(ober, "Hoegaarden");
            klant2.Bestel(ober, "Koffie");

            Console.ReadKey();
        }
    }
}