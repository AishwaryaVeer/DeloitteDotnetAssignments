using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_LambdaQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PizzaOrder> p = new List<PizzaOrder>
            {
               new PizzaOrder
               {OrderID = 100 , OrderDate = DateTime.Now , PizzaType = "Veg", PizzaSize ='S' , Toppings = "SweetCorn", Qty = 3, Price=300  },

               new PizzaOrder
               {OrderID = 200 , OrderDate = DateTime.Now , PizzaType = "Veg", PizzaSize ='M' , Toppings = "SweetCorn", Qty = 9, Price=900  },

               new PizzaOrder
               {OrderID = 300 , OrderDate = DateTime.Now , PizzaType = "Veg", PizzaSize ='M' , Toppings = "Onion", Qty = 7, Price=700  },

               new PizzaOrder
               {OrderID = 400 , OrderDate = DateTime.Now , PizzaType = "Non Veg", PizzaSize ='M' , Toppings = "Egg", Qty = 2, Price=400  },

               new PizzaOrder
               {OrderID = 500 , OrderDate = DateTime.Now , PizzaType = "Non Veg", PizzaSize ='S' , Toppings = "Egg", Qty =10, Price=2000  },

               new PizzaOrder
               {OrderID = 600 , OrderDate = DateTime.Now , PizzaType = "Non Veg", PizzaSize ='S' , Toppings = "Chicken", Qty = 3, Price=2000  }



            };

            //a) Display all pizzas ordered
            Console.WriteLine("(a)===============================================================================================\n");
            foreach (var a in p)
            {
                Console.WriteLine(a.OrderID + " " + a.OrderDate + " " + a.PizzaType+" " + a.PizzaSize + " "+a.Toppings + " " + a.Qty + " " + a.Price);
            }

            Console.WriteLine("(b)===============================================================================================\n");

            //b) based on PizzaType and PizzaSize

            foreach (var a in p.Where(x => x.PizzaType == "Non Veg" && x.PizzaSize == 'S'))
            {
                Console.WriteLine(a.OrderID + " " + a.OrderDate + " " + a.PizzaType + " " + a.PizzaSize + " " + a.Toppings + " " + a.Qty + " " + a.Price);
            }

            Console.WriteLine("(c/d)===============================================================================================\n");

            //c) count of Pizza Sold, Amt collected , group by pizza type.


            var set1 = p.GroupBy(x => x.PizzaType).Select(x => new { PizzaT = x.Key, Count = x.Sum(y => y.Qty), AmtCollect = x.Sum(j => j.Qty * j.Price) });
            
            foreach(var a in set1)
            {
                Console.WriteLine(a.PizzaT + " " + a.Count + " " + a.AmtCollect);
            }

            Console.WriteLine("(e)===============================================================================================\n");

            //e) only Pizza type and toppings hwre size = 'm'
            var set2 = p.Where(x => x.PizzaSize == 'M').Select(x => new { PizzaT = x.PizzaType, Topping = x.Toppings });

            foreach( var a in set2)
            {
                Console.WriteLine(a.PizzaT + " " + a.Topping);
            }

            Console.WriteLine("(f)===============================================================================================\n");

            //f) piza details for max price 
            var set3 = p.Where(y => y.Price == p.Max(x => x.Price));

            foreach (var a in set3)
            {
                Console.WriteLine(a.OrderID + " " + a.OrderDate + " " + a.PizzaType + " " + a.PizzaSize + " " + a.Toppings + " " + a.Qty + " " + a.Price);
            }

            Console.WriteLine("(g)=============================================================================================== \n");

            //f) piza details for min price 
            var set4 = p.Where(y => y.Price == p.Min(x => x.Price));

            foreach (var a in set4)
            {
                Console.WriteLine(a.OrderID + " " + a.OrderDate + " " + a.PizzaType + " " + a.PizzaSize + " " + a.Toppings + " " + a.Qty + " " + a.Price);
            }
        }

    }
}
