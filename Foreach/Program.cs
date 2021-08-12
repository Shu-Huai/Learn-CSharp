using System;
namespace Foreach
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int number in numbers)
            {
                Console.Write(number);
                Console.Write(" ");
            }
        }
    }
}