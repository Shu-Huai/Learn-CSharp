using System;
namespace Get_Factorial
{
    class Program
    {
        public static double Get(uint n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * Get(n - 1);
        }
        public static void Main()
        {
            Console.Write("请输入一个大于等于零的数字：");
            if (uint.TryParse(Console.ReadLine(), out uint number))
            {
                Console.WriteLine("{0}的阶乘是：{1}。", number, Get(number));
            }
            else
            {
                Console.WriteLine("输入错误。");
            }
        }
    }
}