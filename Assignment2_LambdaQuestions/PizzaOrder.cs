using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_LambdaQuestions
{
    class PizzaOrder
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string PizzaType { get; set; }
        public char PizzaSize { get; set; }
        public string Toppings { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
    }
}
