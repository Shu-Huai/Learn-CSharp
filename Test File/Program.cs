using System;
using System.IO;
using System.Text;
namespace Test_File
{
    class Program
    {
        public static void Main()
        {
            using (FileStream writeFile = new("测试文档.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] buffer = Encoding.Default.GetBytes("using (FileStream writeFile = new(" + "\"" + "测试文档.txt" + "\"" + @", FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    byte[] buffer = Encoding.Default.GetBytes(" + "\"\"" + @");
    writeFile.Write(buffer);
    Console.WriteLine(" + "\"" + "写入了{0}字节数据。" + "\"" + @", buffer.Length);
}
using (FileStream readFile = new(" + "\"" + "测试文档.txt" + "\"" + @", FileMode.OpenOrCreate, FileAccess.ReadWrite);
int bufferSize = 512;
int size = bufferSize;
int count = 0;
while (size == bufferSize)
{
    byte[] buffer = new byte[bufferSize];
    size = readFile.Read(buffer);
    string text = Encoding.Default.GetString(buffer, 0, size);
    count++;
    Console.WriteLine(" + "\"" + @"第{0}次，读出了{1}字节数据，数据是：\n“\n{2}\n”。" + "\"" + @", count, size, text);
}");
                writeFile.Write(buffer);
                Console.WriteLine("写入了{0}字节数据。", buffer.Length);
            }
            using FileStream readFile = new("测试文档.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            int bufferSize = 512;
            int size = bufferSize;
            int count = 0;
            while (size == bufferSize)
            {
                byte[] buffer = new byte[bufferSize];
                size = readFile.Read(buffer);
                string text = Encoding.Default.GetString(buffer, 0, size);
                count++;
                Console.WriteLine("第{0}次，读出了{1}字节数据，数据是：\n“\n{2}\n”。", count, size, text);
            }
        }
    }
}