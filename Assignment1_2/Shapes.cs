using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Shapes
    {
        double area;

        //rectanle area
        public void Area(double len, double brd)
        {
            Console.WriteLine("Rectangle");
            area = len * brd;
        }

        //triangle arae
        public void Area(int ba , int height)
        {
            Console.WriteLine("Triangle");
            area = 0.5 * ba * height;
        }

        //circle area
        public void Area(double rad)
        {
            Console.WriteLine("Circle");
            area = 3.14 * rad * rad;
        }

        //square area
        public void Area(float a)
        {
            Console.WriteLine("Square");
            area = a * a;
        }

        public void Display()
        {
            Console.WriteLine("Area :" + area);

        }
       
    }
}
