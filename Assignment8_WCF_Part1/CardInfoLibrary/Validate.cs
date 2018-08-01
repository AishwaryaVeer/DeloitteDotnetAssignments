using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardInfoLibrary
{
    public class Validate : IValidate
    {
        AssignmentsDatabaseEntities db = new AssignmentsDatabaseEntities();
        public bool Transaction(int card, DateTime expdt, int cvv, float transamt)
        {
            if (card <= 0)
                throw new ArgumentException("Card number cannot br 0 or negetive");

            var data = (db.CardInfoes.Where(x => x.CardNumber == card)).SingleOrDefault(); 
            if (data == null)
                throw new ArgumentException("Card number entered is not Valid! ");
            else
            {
                if (expdt.Month != data.expdate.Month && expdt.Year != data.expdate.Year)
                {
                    throw new ArgumentException("Expiry date does not match card details! Invalid Transaction!");
                   
                }

                if(cvv != data.cvvno)
                {
                    throw new ArgumentException("CVV does not match card number! Invalid Transaction!");
                }

                if(transamt>data.balance)
                {
                    throw new ArgumentException("Current balance:" + data.balance + "\n Transaction amount is greater than the balance in your account!Invalid Transaction!");
                }
                
                if (data.expdate.Month == DateTime.Now.Month && data.expdate.Year == DateTime.Now.Year)
                {
                    throw new ArgumentException("Your card has passed it's expiry date");
                }

                data.balance = data.balance - transamt;
                var res = db.SaveChanges();
                if (res > 0)
                    Console.WriteLine("Balance Updated!");
                 
                return true;

                               
            }

        }
    }
}
