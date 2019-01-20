using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Car
{
    public enum Barwa
    {
        Nieznany,
        Bialy,
        Czarny,
        Zielony,
        Czerwony
    }
    public class Samochod
    {
        public string marka { get; }
        public string rejestracja { get; set; }
        public Barwa kolor { get; set; }
        public Samochod(string mar, string rej, Barwa kol)
        {
            marka = mar;
            rejestracja = rej;
            kolor = kol;
        }
        public Samochod(string mar, string rej) : this(mar, rej, Barwa.Nieznany)
        { }
        public void Info()
        {
            Console.WriteLine("Marka: " + marka + " Rejestracja: " + rejestracja + " Kolor: " + kolor);
        }

    }

    class Program
    {
        static void Main()
        {
            Samochod p1 = new Samochod("Audi", "PLE 997", Barwa.Czarny);
            p1.Info();
            Samochod p2 = new Samochod("Merc", "PO 666");
            p2.Info();
            Console.ReadKey();
        }
    }
}