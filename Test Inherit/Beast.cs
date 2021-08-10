using System;
namespace Test_Inherit
{
    class Beast:Person
    {
#pragma warning disable CA1822
        public new void DescribeSelf()
#pragma warning restore CA1822
        {
            Console.WriteLine("我是野兽。");
        }
    }
}