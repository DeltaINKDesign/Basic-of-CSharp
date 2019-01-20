using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            string wejscie = Console.ReadLine();
            try
            {
                int j = int.Parse(wejscie);
                for (int i = 2; i <= j; i++)
                {
                    if (j % i != 0)
                    {
                        Console.WriteLine("Liczba jest pierwsza");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Liczba nie jest pierwsza!");
                        
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