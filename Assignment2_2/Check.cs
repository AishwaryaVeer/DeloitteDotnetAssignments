using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    class Check
    {
        string  ans = "Deloitte Training";


        public void CheckString(string b)
        {
            bool res;
            res = b.Equals(ans);

            if (res)
                Console.WriteLine("The string matches to Deloitte Training");

            else
            {
                throw new NoMatchException();

            }

        }
    }
}
