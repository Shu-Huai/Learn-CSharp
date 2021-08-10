using System;
namespace Test_Inherit
{
    class Person
    {
#pragma warning disable CA1822
        public virtual void DescribeSelf()
#pragma warning restore CA1822
        {
            Console.WriteLine("我是人类。");
        }
    }
}