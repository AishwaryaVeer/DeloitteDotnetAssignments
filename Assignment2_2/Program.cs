using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip;
            Console.WriteLine("Enter a string value");
            ip = Console.ReadLine();

            Check ob = new Check();
            try
            {
                ob.CheckString(ip);
            }

            catch (NoMatchException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
