using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo
{
    internal class Rettangolo
    {
        private int baseRettangolo;
        private int altezzaRettangolo;
        private int areaRettangolo;
        private int perimetroRettangolo;

        // COSTRUTTORE //
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }
        // Perimetro rettangolo //
        public Rettangolo()
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }
        // Stampo il metodo //
        public void StampaRettangolo()
        {
            Console.WriteLine("|____________|");
            Console.WriteLine("Base: " + baseRettangolo);
            Console.WriteLine("Altezza: " + altezzaRettangolo);
            Console.WriteLine("Area: " + areaRettangolo);
            Console.WriteLine("Perimetro: " + perimetroRettangolo);
        }
    }
}