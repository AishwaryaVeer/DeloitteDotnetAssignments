using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaOrder ob1 = new PizzaOrder { OrderID = 100, OrderDate = DateTime.Now, PizzaType = "Veg", PizzaSize = 'S', Toppings = "SweetCorn", Qty = 3, Price = 300 };

            PizzaOrder ob2 = new PizzaOrder { OrderID = 200, OrderDate = DateTime.Now, PizzaType = "Veg", PizzaSize = 'M', Toppings = "SweetCorn", Qty = 9, Price = 900 };

            PizzaOrder ob3 = new PizzaOrder { OrderID = 300, OrderDate = DateTime.Now, PizzaType = "Veg", PizzaSize = 'M', Toppings = "Onion", Qty = 7, Price = 700 };

            CodeDBEntities db = new CodeDBEntities();
            db.PizzaOrders.Add(ob1);
            db.PizzaOrders.Add(ob2);
            db.PizzaOrders.Add(ob3);

            var res = db.SaveChanges();
            if (res > 0)
            {
                Console.WriteLine("data Inserted");

            }


        }
    }
}
