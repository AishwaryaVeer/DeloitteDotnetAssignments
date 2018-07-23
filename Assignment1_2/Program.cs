using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 3.0f;

            Shapes rect = new Shapes();
            rect.Area(4.5, 45.0);
            rect.Display();

            Shapes tri = new Shapes();
            tri.Area(3,5);
            tri.Display();

            Shapes cir = new Shapes();
            cir.Area(5.5);
            cir.Display();

            Shapes sq = new Shapes();
            sq.Area(a);
            sq.Display();

        }
    }
}
