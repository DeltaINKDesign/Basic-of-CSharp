using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    public class Pair<T> where T : IComparable<T>
    {
        public T Left { get; set; }
        public T Right { get; set; }

        public T this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        {
                            return Left;
                        }
                    case 1:
                        {
                            return Right;
                        }
                    default:
                        {
                            throw new IndexOutOfRangeException();
                        }
                }
            }
            set
            {
                switch (i)
                {
                    case 0:
                        {
                            Left = value;
                            break;
                        }
                    case 1:
                        {
                            Right = value;
                            break;

                        }
                    default:
                        {
                            throw new IndexOutOfRangeException();
                        }
                }
            }


        }

        public Pair(T Left, T Right)
        {
            this.Left = Left;
            this.Right = Right;
        }

        public void swap()
        {
            T temp;
            temp = Left;
            Left = Right;
            Right = temp;
        }

        public override string ToString()
        {
            return "[" + Left.ToString() + ";" + Right.ToString() + "]";
        }

        public T Max()
        {
            if (Comparer<T>.Default.Compare(Left, Right) > 0)
            {
                return Left;
            }
            return Right;
        }
    }
    class Animal
    {
        public string Species
        {
            get;
            set;
        }

        public Animal(string Species)
        {
            this.Species = Species;
        }
    }
    class Mammal : Animal
    {
        public Mammal(string Species) : base(Species)
        { }
    }
    class Bird : Animal
    {
        public Bird(string Species) : base(Species)
        { }
    }

    class Program
    {

        static void Generics()
        {
            Pair<string> stringPair = new Pair<string>("Ja", "Druga ja");
            Console.WriteLine(stringPair.ToString());
            stringPair.swap();
            Console.WriteLine(stringPair.ToString());
            Console.WriteLine("Max to: " + stringPair.Max());

            Pair<int> pairOfInts = new Pair<int>(1, 2);
            Console.WriteLine(pairOfInts.ToString());
            pairOfInts.swap();
            Console.WriteLine(pairOfInts.ToString());
            Console.WriteLine("Max to: " + pairOfInts.Max());
            Console.WriteLine(pairOfInts[1]);
            pairOfInts[1] = 3;
            Console.WriteLine(pairOfInts.ToString());
        }

        static void PrintList<T>(List<T> listOfAnimals) where T : Animal //dokonczyc
        {
            foreach (T a in listOfAnimals)
            {
                Console.WriteLine(a.Species);
            }
        }
        static void PrintList2(IEnumerable<Animal> animals)
        {
            foreach (Animal a in animals)
            {
                Console.WriteLine(a.Species);
            }
        }
        static void Main(string[] args)
        {
            Generics();
            List<Bird> ptaszki = new List<Bird>() { new Bird("Wróbel"), new Bird("Sikorka") };
            List<Mammal> ssaki = new List<Mammal>() { new Mammal("Pieseł"), new Mammal("Koteł") };
            PrintList2(ptaszki);
            PrintList2(ssaki);
            Console.ReadKey();
        }
    }
}
