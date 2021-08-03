using System;
namespace Get_Factorial
{
    class GetFactorialClass
    {
        static double GetFactorial(uint n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * GetFactorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("请输入一个大于等于零的数字：");
            if (uint.TryParse(Console.ReadLine(), out uint number))
            {
                Console.WriteLine("{0}的阶乘是：{1}。", number, GetFactorial(number));
            }
            else
            {
                Console.WriteLine("输入错误。");
            }
        }
    }
}