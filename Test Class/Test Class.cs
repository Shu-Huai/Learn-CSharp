using System;
namespace Test_Class
{
    class TestClass
    {
        static void Main()
        {
            Person person = new("吕陟赫", 18, '男');
            Console.WriteLine(person);
            Person.SayHello();
        }
    }
}