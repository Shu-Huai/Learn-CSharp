using System;
namespace Get_Factorial
{
    class GetFactorialClass
    {
        static double GetFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * GetFactorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("请输入一个数字：");
            int number;
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("输入错误。");
                return;
            }
            Console.WriteLine("{0}的阶乘是：{1}。", number, GetFactorial(number));
        }
    }
}