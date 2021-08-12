using System;
namespace Variable_Type
{
    class Program
    {
        public static void Main()
        {
            byte byteVariable = 1;
            sbyte sbyteVariable = -1;
            ushort ushortVariable = 2;
            short shortVariable = -2;
            uint uintVariable = 3;
            int intVariable = -3;
            ulong ulongVariable = 4;
            long longVariable = -4;
            float floatVariable = 5.1F;
            double doubleVariable = 6.2;
            char charVariable = 'A';
            string stringVariable = "Hello World!";
            decimal decimalVariable = 7M;
            bool boolVariable = true;
            var varVariable = 8.3;
            Console.WriteLine("byte变量是：{0}。\nsbyte变量是：{1}。", byteVariable, sbyteVariable);
            Console.WriteLine("无符号短整型变量是：{0}。\n短整型变量是：{1}。", ushortVariable, shortVariable);
            Console.WriteLine("无符号整型变量是：{0}。\n整型变量是：{1}。", uintVariable, intVariable);
            Console.WriteLine("无符号长整型变量是：{0}。\n长整型变量是：{1}。", ulongVariable, longVariable);
            Console.WriteLine("单精度浮点变量是：{0}。\n双精度浮点变量是：{1}。", floatVariable, doubleVariable);
            Console.WriteLine("字符变量是：{0}。\n字符串变量是：{1}。", charVariable, stringVariable);
            Console.WriteLine("decimal变量是：{0}。", decimalVariable);
            Console.WriteLine("布尔变量是：{0}。", boolVariable);
            Console.WriteLine("var变量是：{0}，类型是{1}。", varVariable, varVariable.GetType());
        }
    }
}