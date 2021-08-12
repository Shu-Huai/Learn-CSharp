using System;
using System.Security.Cryptography;
using System.Text;
namespace MD5_Encryption
{
    class Program
    {
        public static string GetMD5(string source)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = md5.ComputeHash(Encoding.Default.GetBytes(source));
            StringBuilder result = new();
            for (int i = 0; i < buffer.Length; i++)
            {
                result.Append(buffer[i].ToString("x2"));
            }
            return result.ToString();
        }
        public static void Main()
        {
            Console.Write("请输入一个密码：");
            Console.WriteLine("加密结果是：{0}。", GetMD5(Console.ReadLine()));
        }
    }
}