using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Rectangle
    {
        public int width;
        public int height;
        public string Show()
        {

            return "[" + width + ";" + height + "]";
        }
    }
    class Program
    {

        static void EnlargeRectangle(ref Rectangle obiekt)
        {
            obiekt.height = obiekt.height * 2;
            obiekt.width = obiekt.width * 2;

        }

        static void Main()
        {
            Rectangle r1 = new Rectangle();
            r1.width = 5;
            r1.height = 4;
            Rectangle r2 = r1;

            Console.WriteLine(r1.Show() + r2.Show());

            EnlargeRectangle(ref r1);
            Console.WriteLine(r1.Show());
            Console.WriteLine(r1.Show() + r2.Show());
            Console.ReadKey();



        }

    }
}
