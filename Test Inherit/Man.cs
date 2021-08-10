using System;
namespace Test_Inherit
{
    class Man : Person
    {
        public override void DescribeSelf()
        {
            Console.WriteLine("我是男人。");
        }
    }
}