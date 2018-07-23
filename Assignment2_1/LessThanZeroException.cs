using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1
{
    class LessThanZeroException : Exception
    {
        string msg;

        public LessThanZeroException()
        {
            msg = "the diffrence is less than 0";

        }

        public LessThanZeroException(string m)
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
