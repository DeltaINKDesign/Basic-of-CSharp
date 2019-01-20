using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Pojazd
    {
        public int Predkosc { get; set; }
        public string Model { get; set; }
        public Pojazd(int Predkosc, string Model)
        {
            this.Predkosc = Predkosc;
            this.Model = Model;
        }
        public string Info()
        {
            return "Model: " + Model + "Prędzkość: " + Predkosc;
        }

    }

    class Car : Pojazd
    {
        public int LiczbaDrzwi { get; set; }
        public Car(int Predkosc, string Model, int LiczbaDrzwi) : base(Predkosc, Model)
        {
            this.LiczbaDrzwi = LiczbaDrzwi;
        }
        public string Info()
        {
            return "Model: " + Model + "Predkosc: " + Predkosc + "Liczba Drzwi: " + LiczbaDrzwi;
        }
    }

    class Samolot : Pojazd
    {
        public int LiczbaMiejsc { get; set; }

        public Samolot(int Predkosc, string Model, int LiczbaMiejsc) : base(Predkosc, Model)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        public string Info()
        {
            return "Model: " + Model + "Predkosc: " + Predkosc + "Liczba miejsc: " + LiczbaMiejsc;
        }

    }


    class Program
    {



        static void Main()
        {
            Pojazd[] pojazdy = new Pojazd[4];

            pojazdy[0] = new Car(360, "Audi ", 2);
            pojazdy[1] = new Car(420, "Porsche ", 2);
            pojazdy[2] = new Samolot(890, "Boening ", 180);
            pojazdy[3] = new Samolot(400, "Helikopter ", 4);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(pojazdy[i].Info());

            }
            Console.ReadKey();

        }
    }
}
