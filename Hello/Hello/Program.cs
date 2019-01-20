using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Jak się nazywasz ?");
            string imie = Console.ReadLine();
            string imiemod = " ";
            imiemod = imiemod.Insert(0, imie.Substring(0, 1).ToUpper() + imie.Substring(1, imie.Length - 1));
            Console.WriteLine("Pozdrawiam Cię " + imiemod);

            Console.WriteLine("Podaj liczbe: ");
            string test = Console.ReadLine();

            try
            {
                int liczba = int.Parse(test);
                int a;
                for (a = 2; a <= liczba; a++)
                {
                    if (liczba % a == 0)
                    {
                        a = a + 1;
                    }
                    if (liczba % a != 0)
                    {
                        Console.WriteLine("Liczba jest parzysta");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Liczba nie jest parzysta");
                        break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Podano zły typ");
            }
        }
    }
}