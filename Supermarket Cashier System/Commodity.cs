using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Supermarket_Cashier_System
{
    class Commodity
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public double Price { get; set; }
        public Commodity(string name, string ID, double price)
        {
            Name = name;
            this.ID = ID;
            Price = price;
        }
    }
}