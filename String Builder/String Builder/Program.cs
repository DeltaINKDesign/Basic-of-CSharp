using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    public class Program
    {
        public static void Main()
        {
            StringBuilder mSB = new StringBuilder("", 100);
            for (int i = 0; i < 16; i++)
            {
                mSB.Append("na ");
            }
            mSB.Append("Batman!!!");
            Console.WriteLine(mSB.ToString());
            Console.WriteLine("Batmana znajdziesz w: " + mSB.ToString().IndexOf("Batman"));
            mSB.Insert(mSB.ToString().IndexOf("Batman"), "...");
            Console.WriteLine(mSB.ToString());
        }
    }
}