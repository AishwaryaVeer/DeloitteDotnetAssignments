using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1
{
    class NumberFormat
    {
        
        public void PrintNumber(int number)
        {
            Console.WriteLine(String.Format("Output, Number with commas: {0:0,0}", number));
        }
        public void PrintMoney(int number)
        {
            Console.WriteLine(string.Format("Output Money: {0:c}", number));

        }
        public void PrintHexaDecimal(int number)
        {
            Console.WriteLine(String.Format("Output Hexadecimal Number: {0:X4}", number));
        }
    }
}
