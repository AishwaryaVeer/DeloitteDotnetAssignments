using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1
{
    class Usertrail
    {
        int val1, val2;
        
        public void Values(int a, int b)
        {
            val1 = a;
            val2 = b;
        }
        public void Show()
        {
            if (val1 > 0)
                Console.WriteLine("Value 1 is greater than 0");

            else if (val1 <0)
                Console.WriteLine("Value 1 is less than 0");

            if (val2 > 0)
                Console.WriteLine("Value 2 is greater than 0");

            else if (val2 < 0)
                Console.WriteLine("Value 2 is less than 0");
        }

        public void Calculate()
        {
            int res = val1 - val2;
            if (res < 0)
            {
                throw new LessThanZeroException("Difference is 0. diffrence cannot be 0. Please check the values entered");
            }
            else
                Console.WriteLine("Result :" + res);
        }
    }
}
