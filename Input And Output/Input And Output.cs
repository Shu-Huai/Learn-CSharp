using System;
namespace Input_And_Output
{
    class InputAndOutput
    {
        static void Main()
        {
            Console.WriteLine("整型变量是：{0:0100}。\n双精度浮点变量是：{1:*0.00}。", 3, 6.1);
            Console.Write("请输入你的名字：");
            string name = Console.ReadLine();
            Console.WriteLine("你的名字是：{0}。", name);
            Console.Write("请输入你的年龄和性别，用空格隔开：");
            string[] inputString = Console.ReadLine().Split(" ");
            if (inputString.Length == 2 && Convert.ToInt32(inputString[0]) >= 0 && "男女".Contains(inputString[1]))
            {
                Console.WriteLine("你的年龄是：{0}。\n你的性别是：{1}。", inputString[0], inputString[1]);
            }
            else
            {
                Console.WriteLine("非法输入。");
            }
        }
    }
}