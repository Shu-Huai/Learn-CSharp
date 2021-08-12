using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Supermarket_Cashier_System
{
    class Warehouse
    {
        public enum Type
        {
            Banana,
            MobilePhone,
            Laptop,
            SoyaSauce
        }
        public List<List<Commodity>> Commodities { get; set; }
        public Warehouse(int shelfNumber = 0)
        {
            Commodities = new();
            for (int i = 0; i < shelfNumber; i++)
            {
                Commodities.Add(new());
            }
        }
        public void ShowCommodities()
        {
            for (int i = 0; i < Commodities.Count; i++)
            {
                if (Commodities[i].Count > 0)
                {
                    Console.WriteLine("商品：{0}\t数量：{1}\t单价：{2}", Commodities[i][0].Name.PadRight(20), Commodities[i].Count, Commodities[i][0].Price);
                }
            }
        }
        public void Stock(Type type, int number)
        {
            switch (type)
            {
                case Type.Banana:
                    for (int i = 0; i < number; i++)
                    {
                        Commodities[(int)type].Add(new Banana("香蕉", Guid.NewGuid().ToString(), 5));
                    }
                    break;
                case Type.MobilePhone:
                    for (int i = 0; i < number; i++)
                    {
                        Commodities[(int)type].Add(new MobilePhone("手机", Guid.NewGuid().ToString(), 2000));
                    }
                    break;
                case Type.Laptop:
                    for (int i = 0; i < number; i++)
                    {
                        Commodities[(int)type].Add(new Laptop("手提电脑", Guid.NewGuid().ToString(), 5000));
                    }
                    break;
                case Type.SoyaSauce:
                    for (int i = 0; i < number; i++)
                    {
                        Commodities[(int)type].Add(new SoyaSauce("酱油", Guid.NewGuid().ToString(), 20));
                    }
                    break;
                default:
                    break;
            }
        }
        public Commodity[] Ship(Type type, int number)
        {
            if (Commodities[(int)type].Count < number)
            {
                throw new Exception("数量不足。");
            }
            Commodity[] outCommodities = new Commodity[number];
            for (int i = 0; i < number; i++)
            {
                outCommodities[i] = Commodities[(int)type][0];
                Commodities[(int)type].RemoveAt(0);
            }
            return outCommodities;
        }
    }
}