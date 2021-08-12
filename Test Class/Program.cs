using System;
namespace Test_Class
{
    class Program
    {
        public static void Main()
        {
            Person person = new("吕陟赫", 18, '男');
            Console.WriteLine(person);
            Person.SayHello();
        }
    }
}