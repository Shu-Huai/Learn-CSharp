using System;
using System.Linq;
namespace Test_Function
{
    class TestFunction
    {
        public static int GetMax(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber ? firstNumber : secondNumber;
        }
        public static int GetMax(int[] list)
        {
            return list.Max();
        }
        public static void GetMaxAndMin(int[] list, out int max, out int min)
        {
            max = list.Max();
            min = list.Min();
        }
        public static void AddFive(int number)
        {
            if (number > 0)
            {
                return;
            }
        }
        public static void AddFive(ref int number)
        {
            number += 5;
        }
        public static void AddFive(ref double number)
        {
            number += 5;
        }
        public static int GetSum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            return sum;
        }
        public static void Loop(int times, int maxTimes)
        {
            Console.WriteLine("这是第{0}次循环。", times + 1);
            times++;
            if (times >= maxTimes)
            {
                return;
            }
            Loop(times, maxTimes);
        }
        static void Main()
        {
            Console.WriteLine("3和5的最大值是：{0}。", GetMax(3, 5));
            int[] list = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("1，2，3，4，5的最大值是：{0}。", GetMax(list));
            GetMaxAndMin(list, out int max, out int min);
            Console.WriteLine("1，2，3，4，5的最大最小值是：{0}和{1}。", max, min);
            int number = 5;
            AddFive(ref number);
            Console.WriteLine("5加5的结果是：{0}", number);
            double doubleNumber = 5.5;
            AddFive(ref doubleNumber);
            Console.WriteLine("5.5加5的结果是：{0}", doubleNumber);
            Console.WriteLine("1加2加3加4加5加6的结果是：{0}", GetSum(1, 2, 3, 4, 5, 6));
            Console.WriteLine("需要进行10次循环。");
            Loop(0, 10);
        }
    }
}