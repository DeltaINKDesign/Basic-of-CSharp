using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUtil
{
    public class IntArrayUtil
    {
        public static int FindBiggest(int[] tablica)
        {
            int najw = tablica[0];
            for (int i = 1; i < tablica.Length - 1; i++)
            {
                if (najw < tablica[i])
                    najw = tablica[i];
            }
            return najw;
        }
        public static int FindLeast(int[] tablica)
        {
            int najmn = tablica[0];
            for (int i = 1; i < tablica.Length - 1; i++)
            {
                if (najmn > tablica[i])
                    najmn = tablica[i];
            }
            return najmn;
        }
        public static int[] Sort(int[] tablica)
        {
            int temp;
            for (int j = 0; j < tablica.Length; j++)
            {
                for (int i = 0; i < tablica.Length; i++)
                {
                    if (tablica[j] < tablica[i])
                    {
                        temp = tablica[i];
                        tablica[i] = tablica[j];
                        tablica[j] = temp;
                    }
                }
            }
            return tablica;
        }
    }
    class Program
    {
        static void Main()
        {
            int[] tab = new int[] { 3, 5, 2, 7, 1, 6, 3, 6, -20, -11 };
            int[] tab2 = new int[tab.Length];
            Array.Copy(tab, 0, tab2, 0, tab.Length);
            Console.WriteLine("Tablica 1");
            Console.WriteLine("Największa: " + IntArrayUtil.FindBiggest(tab));
            Console.WriteLine("Najmniejsz: " + IntArrayUtil.FindLeast(tab));
            Console.WriteLine("Sorted: ");
            foreach (int element in IntArrayUtil.Sort(tab))
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Tablica 2");
            Array.Sort(tab2);
            Console.WriteLine("Najmniejsza: " + tab2[0]);
            Console.WriteLine("Największa: " + tab2[tab2.Length - 1]);
            Console.WriteLine("Sorted:");
            foreach (int element in tab2)
            {
                Console.WriteLine(element);
            }
        }
    }
}
