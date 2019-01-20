using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Class_2
{
    public class Samochod
    {
        public string marka;
        public string rejestracja;
        public string kolor;
        public Samochod(string mar, string rej, string kol)
        {
            marka = mar;
            rejestracja = rej;
            kolor = kol;
        }
        public void Info()
        {
            Console.WriteLine("Marka: " + marka + " Rejestracja: " + rejestracja + " Kolor: " + kolor);
        }

    }
    class Program
    {
        static void Main()
        {
            Samochod p1 = new Samochod("Audi", "PLE 997", "czarny");
            p1.Info();
            Console.ReadKey();
        }
    }
}