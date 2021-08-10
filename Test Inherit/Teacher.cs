using System;
namespace Test_Inherit
{
    class Teacher : Person
    {
#pragma warning disable CA182
        public new void DescribeSelf()
#pragma warning restore CA1822
        {
            Console.WriteLine("我是老师。");
        }
    }
}