using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVUtil
{
    public class CSVUtil
    {
        static string[] tablica;
        static int[] tablicaliczb;

        public static int znajdzNajw(string tekst)
        {
            try
            {

                podziel(tekst);
                Array.Sort(tablicaliczb);
                return tablicaliczb[tablica.Length - 1];
            }
            catch (Exception e)
            {
                throw new FormatException();
                return 0;
            }
        }

        public static int znajdzNajm(string tekst)
        {
            try
            {
                podziel(tekst);
                Array.Sort(tablicaliczb);
                return tablicaliczb[0];

            }
            catch (Exception e)
            {
                throw new FormatException();
                return 0;
            }
        }

        public static string sortuj(string tekst)
        {
            try
            {
                podziel(tekst);
                Array.Sort(tablicaliczb);
                string tablicazwrot = "";
                int i = 0;
                while (i != tablicaliczb.Length)
                {
                    tablicazwrot += tablicaliczb[i] + ",";
                    i++;
                }
                return tablicazwrot;

            }
            catch (Exception e)
            {
                throw new FormatException();

                return "null";
            }
        }

        public static void podziel(string tekst)
        {
            tablica = tekst.Split(',');
            tablicaliczb = new int[tablica.Length];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablicaliczb[i] = int.Parse(tablica[i]);
            }

        }

    }

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();



            for (int i = 0; i < CSVUtil.sortuj(input).Length; i++)
            {
                Console.Write(CSVUtil.sortuj(input)[i]);
            }


            Console.WriteLine("\n" + CSVUtil.znajdzNajm(input));
            Console.WriteLine("\n" + CSVUtil.znajdzNajw(input));

        }
    }
}
