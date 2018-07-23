using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime db1 = DateTime.Parse("10 / 23 / 1996");
            DateTime db2 = DateTime.Parse("07 / 17 / 1897");//adult >18 
            DateTime db3 = DateTime.Parse("07 / 17 / 2015");//minor <18
            DateTime db4= DateTime.Parse("10 / 17 / 2000"); // ==18 but minor
            DateTime db5 = DateTime.Parse("6 / 17 / 2000");//==18 , adult
            DateTime db6 = DateTime.Parse("7 / 13 / 2000");//==18 , adult
            DateTime db7 = DateTime.Parse("7 / 20 / 2000");//==18 , minor

            //constructor 1
            Person p1 = new Person("aish", "veer", "aish.veer@abc", db1 );
            p1.Display();
            p1.Adult();
            p1.Birthday();
            p1.SunSign();

            Console.WriteLine("==================================================");

            //constructor 2
            Person p2 = new Person("aish", "veer", "aish.veer@abc");
            p2.Display();
            p2.Adult();
            p2.Birthday();
            p2.SunSign();

            Console.WriteLine("==================================================");

            //construcor 3


            Person p3 = new Person("aish", "veer", db1);
            p3.Display();
            p3.Adult();
            p3.Birthday();
            p3.SunSign();

            Console.WriteLine("==================================================");


            //Birthday 


            Person p4 = new Person("alex", "deen", db6);
            p4.Display();
            p4.Adult();
            p4.Birthday();
            p4.SunSign();

            Console.WriteLine("==================================================");


            //db3

            Person p5 = new Person("alex", "deen", db3);
            p5.Display();
            p5.Adult();
            p5.Birthday();
            p5.SunSign();

            Console.WriteLine("==================================================");

            //db4


            Person p6 = new Person("alex", "deen", db7);
            p6.Display();
            p6.Adult();
            p6.Birthday();
            p6.SunSign();

            Console.WriteLine("==================================================");

            //db4






        }
    }
}
