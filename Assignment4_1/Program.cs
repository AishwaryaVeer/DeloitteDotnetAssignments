using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_1
{
    class Program
    {
        public delegate void Number(int num);
        static void Main(string[] args)
        {
            NumberFormat ob = new NumberFormat();

            Console.WriteLine("Please eneter the number ");
            int no = int.Parse(Console.ReadLine());

            Number N = ob.PrintNumber;
            N += ob.PrintMoney;
            N += ob.PrintHexaDecimal;

            N(no);



        }
    }
}
