using System;
namespace Test_Inherit
{
    class Man : Person
    {
#pragma warning disable CA1822 // 将成员标记为 static
        public new void DescribeSelf()
#pragma warning restore CA1822 // 将成员标记为 static
        {
            Console.WriteLine("我是男人。");
        }
    }
}