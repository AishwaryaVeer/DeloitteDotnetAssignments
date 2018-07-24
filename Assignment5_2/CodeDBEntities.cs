using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Assignment5_2
{
    class CodeDBEntities: DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public CodeDBEntities() : base("MyDB") { }
    }
}
