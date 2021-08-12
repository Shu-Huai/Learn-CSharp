using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Supermarket_Cashier_System
{
    class SoyaSauce : Commodity
    {
        public SoyaSauce(string name, string ID, double price) : base(name, ID, price)
        {
        }
        public override string ToString()
        {
            return $"商品：{Name,-20}\t编号：{ID}\t价格：{Price}";
        }
    }
}