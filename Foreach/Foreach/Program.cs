using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj rozmiar tablicy");
            int rozmiar = int.Parse(Console.ReadLine());
            int[] tablica = new int[rozmiar];
            Random rand = new Random();
            for (int i = 0; i < rozmiar; i++)
                tablica[i] = rand.Next(1, 10);
            Array.Sort(tablica);
            foreach (int element in tablica)
            {
                Console.WriteLine(element);
            }
        }
    }
}
