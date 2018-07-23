using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Accounts
    {
        int Account_No;
        string Cust_name;
        string Account_type;
        char Trans_type;
        double amount;
        double balance;

        public Accounts(int acc_no, string name, string acc_type)
        {
            Account_No = acc_no;
            Cust_name = name;
            Account_type = acc_type;

        }
        public void credit(double amount)
        {
            this.amount = amount;
            balance = balance + amount;
            Console.WriteLine("the amount" + amount + " has been credited to your account");

        }

        public void debit(double amt)
        {
            amount = amt;
            balance = balance - amt;
            Console.WriteLine("the amount" + amt + " has been debited to your account");

        }

        public void Transaction(char type, double amo)
        {
            Trans_type = type;

            if (Trans_type == 'D')
                credit(amo);

            else if (Trans_type == 'W')
                debit(amo);

            else
                Console.Write("invalid Transaction type");


        }

        public void ShowData()
        {
            Console.WriteLine("Acount Number :" + Account_No);
            Console.WriteLine("Customer Name :" + Cust_name);
            Console.WriteLine("Acount Type :" + Account_type);
            Console.WriteLine("Transaction Type :" + Trans_type);
            Console.WriteLine("Amount Transacted :" + amount);
            Console.WriteLine("Balance :" + balance);
        }


    }
}
