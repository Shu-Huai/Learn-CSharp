using System;
namespace Supermarket_Cashier_System
{
    class Program
    {
        public static void Main()
        {
            Supermarket supermarket = new(4);
            supermarket.Sell();
        }
    }
}