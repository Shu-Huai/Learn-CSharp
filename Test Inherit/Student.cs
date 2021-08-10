using System;
namespace Test_Inherit
{
    class Student : Person
    {
        public override void DescribeSelf()
        {
            Console.WriteLine("我是学生。");
        }
    }
}