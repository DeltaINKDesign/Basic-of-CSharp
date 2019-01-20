using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
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
        override public string ToString()
        {
            return "Model: " + Model + " Prędzkość: " + Predkosc;
        }

    }

    class Car : Pojazd, ITuningowalny
    {
        public int LiczbaDrzwi { get; set; }
        public Car(int Predkosc, string Model, int LiczbaDrzwi) : base(Predkosc, Model)
        {
            this.LiczbaDrzwi = LiczbaDrzwi;
        }
        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba Drzwi: " + LiczbaDrzwi;
        }

        public void ZwiekszPredkosc(int parametr)
        {
            Predkosc += parametr;
        }
    }

    class Samolot : Pojazd
    {
        public int LiczbaMiejsc { get; set; }

        public Samolot(int Predkosc, string Model, int LiczbaMiejsc) : base(Predkosc, Model)
        {

            this.LiczbaMiejsc = LiczbaMiejsc;
        }

        override public string ToString()
        {
            return "Model: " + Model + " Predkosc: " + Predkosc + " Liczba miejsc: " + LiczbaMiejsc;
        }

    }

    public interface ITuningowalny
    {
        void ZwiekszPredkosc(int parametr);
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
            ITuningowalny zmienna = (ITuningowalny)pojazdy[0];
            zmienna.ZwiekszPredkosc(60);

            foreach (var i in pojazdy)
            {
                if (i is ITuningowalny)
                {


                    ITuningowalny tuningowalny = (ITuningowalny)i;
                    tuningowalny.ZwiekszPredkosc(10);
                }
                Console.WriteLine(i);  //niejawne wywolanie, bez wywolywania Info lub ToStringa. 

            }
            Console.ReadKey();

        }
    }
}

