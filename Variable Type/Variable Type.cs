using System;
namespace Variable_Type
{
    class VariableType
    {
        static void Main(string[] args)
        {
            int intVariable = 2;
            float floatVariable = 2.1F;
            double doubleVariable = 2.2;
            long longVariable = 3;
            char charVariable = 'A';
            string stringVariable = "Hello World!";
            decimal decimalVariable = 4M;
            Console.WriteLine("整型变量是：{0}。", intVariable);
            Console.WriteLine("单精度浮点变量是：{0}。", floatVariable);
            Console.WriteLine("双精度浮点变量是：{0}。", doubleVariable);
            Console.WriteLine("长整型变量是：{0}。", longVariable);
            Console.WriteLine("字符变量是：{0}。", charVariable);
            Console.WriteLine("字符串变量是：{0}。", stringVariable);
            Console.WriteLine("decimal变量是：{0}。", decimalVariable);
        }
    }
}