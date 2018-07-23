using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Usertrail ob = new Usertrail();
                ob.Values(33, 9);
                ob.Show();
                ob.Calculate();

                Usertrail ob1 = new Usertrail();
                ob1.Values(8, -1);
                ob1.Show();
                ob1.Calculate();

                Usertrail ob2 = new Usertrail();
                ob2.Values(-9, 0);
                ob2.Show();
                ob2.Calculate();
            }

            catch (LessThanZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

    }
}
