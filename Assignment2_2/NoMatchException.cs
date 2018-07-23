using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    class NoMatchException : Exception
    {
       
        string msg;

        public NoMatchException()
        {
            msg = "Input string is not matching to Deloitte Training";

        }

        public NoMatchException(string m)
        {
            msg = m;

        }

        public override string Message
        {
            get
            {
                return msg;
            }
        }

    }
}
   

