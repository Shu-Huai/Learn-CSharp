using System;
namespace Foreach
{
    class Foreach
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int number in numbers)
            {
                Console.Write(number);
                Console.Write(" ");
            }
        }
    }
}