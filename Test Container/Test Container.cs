using System;
using System.Collections.Generic;
namespace Test_Container
{
    class TestContainer
    {
        private static void Main()
        {
            Console.Write("请输入一句话：");
            string sentence = Console.ReadLine();
            Dictionary<char, int> count = new();
            foreach (char character in sentence)
            {
                if (!string.IsNullOrWhiteSpace(character.ToString()))
                {
                    if (count.ContainsKey(character))
                    {
                        count[character]++;
                    }
                    else
                    {
                        count.Add(character, 1);
                    }
                }
            }
            Console.WriteLine("字符出现的次数是：");
            int formatCount = 0;
            foreach (KeyValuePair<char, int> elem in count)
            {
                Console.Write("{0}：{1: 0}次", elem.Key, elem.Value);
                formatCount++;
                if (formatCount % 5 == 0)
                {
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("\t");
                }
            }
        }
    }
}