using System;
namespace Test_Inherit
{
    class Teacher : Person
    {
        public override void DescribeSelf()
        {
            Console.WriteLine("我是老师。");
        }
    }
}