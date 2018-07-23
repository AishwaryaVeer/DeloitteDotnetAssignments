using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Account_No1;
            string Cust_name1;
            string Account_type1;
            char Trans_type1;
            double amount1;
            

            Console.WriteLine("enter account number , name , account type, tranaction type and amount");

            Account_No1 = int.Parse(Console.ReadLine());
            Cust_name1 = Console.ReadLine();
            Account_type1= Console.ReadLine();
            Trans_type1 = char.Parse(Console.ReadLine());
            amount1 = double.Parse(Console.ReadLine());


            Accounts obj1 = new Accounts(Account_No1, Cust_name1, Account_type1);
            obj1.Transaction(Trans_type1, amount1);
            obj1.ShowData();

            Console.WriteLine(" Next tranaction type and amount");

            Trans_type1 = char.Parse(Console.ReadLine());
            amount1 = double.Parse(Console.ReadLine());

            obj1.Transaction(Trans_type1, amount1);
            obj1.ShowData();

            

        }
    }
}
