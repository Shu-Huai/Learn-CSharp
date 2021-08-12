using System;
namespace Supermarket_Cashier_System
{
    class SupermarketCashierSystem
    {
        private static void Main()
        {
            Supermarket supermarket = new(4);
            supermarket.Sell();
        }
    }
}