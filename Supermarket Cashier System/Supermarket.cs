using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Supermarket_Cashier_System
{
    class Supermarket
    {
        public Warehouse House { get; set; }
        public Supermarket(int shelfNumber = 0)
        {
            House = new(shelfNumber);
            for (int i = 0; i < shelfNumber; i++)
            {
                House.Stock((Warehouse.Type)i, 100);
            }
        }
        public static Warehouse.Type ConvertToType(string type)
        {
            return type switch
            {
                "香蕉" => Warehouse.Type.Banana,
                "手提电脑" => Warehouse.Type.Laptop,
                "手机" => Warehouse.Type.MobilePhone,
                "酱油" => Warehouse.Type.SoyaSauce,
                _ => throw new Exception("类型错误。"),
            };
        }
        public static double GetTotalPrice(Commodity[] commodities)
        {
            double totalPrice = 0;
            for (int i = 0; i < commodities.Length; i++)
            {
                totalPrice += commodities[i].Price;
            }
            return totalPrice;
        }
        public void Sell()
        {
            Console.WriteLine("欢迎光临，请问您需要些什么？");
            House.ShowCommodities();
            Console.Write("需要：");
            string wanted = Console.ReadLine();
            Console.Write("数量：");
            int number = int.Parse(Console.ReadLine());
            Commodity[] result = House.Ship(ConvertToType(wanted), number);
            Console.WriteLine("购买：");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            double totalPrice = GetTotalPrice(result);
            Console.WriteLine("总价：{0}元。", totalPrice);
            Console.Write("打折方式：\n1. 不打折。\n2. 打九折。\n3. 打85折。\n4. 买300送50。\n5. 买500送100。\n请选择：");
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 2:
                    totalPrice *= 0.9;
                    break;
                case 3:
                    totalPrice *= 0.8;
                    break;
                case 4:
                    totalPrice = totalPrice > 300 ? totalPrice - ((int)(totalPrice / 300) * 50) : totalPrice;
                    break;
                case 5:
                    totalPrice = totalPrice > 500 ? totalPrice - ((int)(totalPrice / 500) * 100) : totalPrice;
                    break;
                default:
                    break;
            }
            Console.WriteLine("总价：{0}元。", totalPrice);
        }
    }
}