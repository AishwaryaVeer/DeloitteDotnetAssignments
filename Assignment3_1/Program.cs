using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1
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
               {OrderID = 600 , OrderDate = DateTime.Now , PizzaType = "Non Veg", PizzaSize ='L' , Toppings = "Chicken", Qty = 3, Price=2000  }



            };

            //a) Display all pizzas ordered
            Console.WriteLine("(a)===============================================================================================\n");
            var data = from t in p
                       select t;
            foreach (var a in data)
            {
                Console.WriteLine(a.OrderID + " " + a.OrderDate + " " + a.PizzaType + " " + a.PizzaSize + " " + a.Toppings + " " + a.Qty + " " + a.Price);
            }

            Console.WriteLine("(b)===============================================================================================\n");

            //b) based on PizzaType and PizzaSize

            var data2 = from t in p
                        where t.PizzaType == "Veg" && t.PizzaSize == 'M'
                        select t;

            foreach (var a in data2)
            {
                Console.WriteLine(a.OrderID + " " + a.OrderDate + " " + a.PizzaType + " " + a.PizzaSize + " " + a.Toppings + " " + a.Qty + " " + a.Price);
            }

            Console.WriteLine("(c)===============================================================================================\n");

            //c) count of Pizza Sold, Amt collected , group by pizza type.

            var data3 = from t in p
                        group t by t.PizzaType into grp
                        select new { GrpName = grp.Key, Count = grp.Sum(y => y.Qty), AmtCollect = grp.Sum(j => j.Qty * j.Price) };

          
            foreach (var a in data3)
            {
                Console.WriteLine(a.GrpName + " " + a.Count + " " + a.AmtCollect);

            }

            Console.WriteLine("(d)===============================================================================================\n");

            //c) count of Pizza Sold, Amt collected , group by pizza size.

            var data4 = from t in p
                        group t by t.PizzaSize into grp
                        select new { GrpName = grp.Key, Count = grp.Sum(y => y.Qty), AmtCollect = grp.Sum(j => j.Qty * j.Price) };


            foreach (var a in data4)
            {
                Console.WriteLine(a.GrpName + " " + a.Count + " " + a.AmtCollect);

            }

            Console.WriteLine("(e)===============================================================================================\n");

            //e) only Pizza type and toppings where size = 'm'

            var data5 = from t in p
                        where t.PizzaSize == 'M'
                        select new { PizzaT = t.PizzaType, Topping = t.Toppings };

            
            foreach (var a in data5)
            {
                Console.WriteLine(a.PizzaT + " " + a.Topping);
            }

            Console.WriteLine("(f)===============================================================================================\n");

            //f) pizza details for max price 

            var data6 = from t in p
                        where t.Price == (p.Max(x => x.Price))
                        select t;
           

            foreach (var a in data6)
            {
                Console.WriteLine(a.OrderID + " " + a.OrderDate + " " + a.PizzaType + " " + a.PizzaSize + " " + a.Toppings + " " + a.Qty + " " + a.Price);
            }

            Console.WriteLine("(g)=============================================================================================== \n");

            //g) piza details for min price 

            var data7 = from t in p
                        where t.Price == (p.Min(x => x.Price))
                        select t;

            foreach (var a in data7)
            {
                Console.WriteLine(a.OrderID + " " + a.OrderDate + " " + a.PizzaType + " " + a.PizzaSize + " " + a.Toppings + " " + a.Qty + " " + a.Price);
            }
        
    }
    }
}
