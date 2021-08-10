using System;
namespace Test_Inherit
{
    class Beast:Person
    {
        public override void DescribeSelf()
        {
            Console.WriteLine("我是野兽。");
        }
    }
}