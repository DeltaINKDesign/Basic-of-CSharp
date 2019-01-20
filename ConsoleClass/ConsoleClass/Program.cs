using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClass
{
    public class Samochod
    {
        public string marka;
        public string rejestracja;
        public string kolor;
        public Samochod(string marka, string rejestracja, string kolor)
        {

        }

    }
    class Program
    {
        static void Main()
        {
            Samochod p1 = new Samochod("Audi", "PLE 997", "czarny");
            Console.WriteLine(p1.marka + p1.rejestracja + p1.kolor);
            Console.ReadKey();
        }
    }
}
