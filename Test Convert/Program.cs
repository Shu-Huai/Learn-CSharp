using System;
namespace Test_Convert
{
    class TestConvert
    {
        static void Main(string[] args)
        {
            int intVariable = Convert.ToInt32("1234");
            double doubleVariable = Convert.ToDouble("123.4");
            Console.WriteLine("整型数是：{0}。\n双精度浮点数是：{1}。", intVariable, doubleVariable);
            try
            {
                intVariable = Convert.ToInt32("1234A");
                Console.WriteLine("整型数是：{0}。\n", intVariable);
            }
            catch (FormatException)
            {
                Console.WriteLine("不能转换\"1234A\"");
            }
        }
    }
}