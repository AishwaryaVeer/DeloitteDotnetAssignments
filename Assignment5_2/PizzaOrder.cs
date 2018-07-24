using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment5_2
{
    //POCO class
    class PizzaOrder
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string PizzaType { get; set; }
        [Required]
        public char PizzaSize { get; set; }
        [Required]
        public string Toppings { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
