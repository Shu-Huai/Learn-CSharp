using System;
using System.Collections;
namespace Test_Random
{
    class Program
    {
        public static void Main()
        {
            int top = 0;
            bool isSuccess = false;
            while (!isSuccess)
            {
                Console.Write("请输入随机数的上限：");
                if (int.TryParse(Console.ReadLine(), out top) && top != 0)
                {
                    isSuccess = true;
                }
                else
                {
                    Console.WriteLine("输入有误，请重新输入。");
                }
            }
            Random randomGetter = new();
            ArrayList list = new(top);
            while (list.Count < top)
            {
                int number = randomGetter.Next(0, top);
                if (!list.Contains(number))
                {
                    list.Add(number);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", list[i]);
            }
        }
    }
}