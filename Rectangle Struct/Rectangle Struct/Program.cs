using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Struct
{
    class Program
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
        static void Main()
        {
            Rectangle r1 = new Rectangle();
            r1.width = 10;
            r1.height = 4;
            Console.WriteLine(r1.Show());

        }

    }
}