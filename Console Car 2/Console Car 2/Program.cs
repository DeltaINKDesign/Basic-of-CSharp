using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
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
        public static int Licznik;

        public string marka { get; }
        public string rejestracja { get; set; }
        public Barwa kolor { get; set; }
        public Samochod(string mar, string rej, Barwa kol)
        {
            marka = mar;
            rejestracja = rej;
            kolor = kol;
            Licznik++;
        }
        public Samochod(string mar, string rej) : this(mar, rej, Barwa.Nieznany)
        { }
        public void Info()
        {
            Console.WriteLine("Marka: " + marka + " Rejestracja: " + rejestracja + " Kolor: " + kolor + " Licznik: " + Licznik);
        }

        ~Samochod()
        {
            Licznik--;
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
            p1 = null;
            Console.WriteLine("Licznik po nullu: " + Samochod.Licznik);
            p2 = null;
            Console.WriteLine("Licznik po nullu: " + Samochod.Licznik);
            Console.ReadKey();
        }
    }
}

