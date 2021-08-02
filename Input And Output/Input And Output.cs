using System;
namespace Input_And_Output
{
    class InputAndOutput
    {
        static void Main(string[] args)
        {
            Console.Write("请输入你的名字：");
            string name = Console.ReadLine();
            Console.WriteLine("你的名字是{0}。", name);
        }
    }
}