using System;
namespace Test_Random
{
    class TestRandom
    {
        static void Main()
        {
            Random randomGetter = new Random();
            Console.WriteLine(randomGetter);
            Console.WriteLine(randomGetter.Next(0, 10));
            Console.WriteLine(randomGetter.Next(100));
            Console.WriteLine(randomGetter.NextDouble());
        }
    }
}