using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2
{
    class Shapes
    {
        double area;

        //rectanle area

        [MethodInfo(MethodName ="Area", ReturnType ="void",Parameters ="2 parameters: double,double",Message ="used to calculate the area of a rectangle")]
        public void Area(double len, double brd)
        {
            Console.WriteLine("Rectangle");
            area = len * brd;
        }

        //triangle arae
        [MethodInfo(MethodName = "Area", ReturnType = "void", Parameters = "2 parameters: int,int", Message = "used to calculate the area of a trianlge")]
        public void Area(int ba, int height)
        {
            Console.WriteLine("Triangle");
            area = 0.5 * ba * height;
        }

        //circle area
        [MethodInfo(MethodName = "Area", ReturnType = "void", Parameters = "1 parameter: double", Message = "used to calculate the area of a circle")]
        public void Area(double rad)
        {
            Console.WriteLine("Circle");
            area = 3.14 * rad * rad;
        }

        //square area
        [MethodInfo(MethodName = "Area", ReturnType = "void", Parameters = "1 parameter: float", Message = "used to calculate the area of a square")]
        public void Area(float a)
        {
            Console.WriteLine("Square");
            area = a * a;
        }

        [MethodInfo(MethodName = "Display", ReturnType = "void", Parameters = "no input parameters", Message = "used to display the area calculated")]
        public void Display()
        {
            Console.WriteLine("Area :" + area);

        }

    }
}
