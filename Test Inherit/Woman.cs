using System;
namespace Test_Inherit
{
    class Woman : Person
    {
#pragma warning disable CA1822
        public new void DescribeSelf()
#pragma warning restore CA1822 
        {
        Console.WriteLine("我是女人。");
        }
    }
}