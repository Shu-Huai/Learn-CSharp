using System;
using System.IO;
using System.Text;
namespace Test_File
{
    class TestFile
    {
        private static void Main()
        {
            using (FileStream writeFile = new("测试文档.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] buffer = Encoding.Default.GetBytes("using (FileStream writeFile = new(" + "\"" + "测试文档.txt" + "\"" + @", FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    byte[] buffer = Encoding.Default.GetBytes(" + "\"\"" + @");
    writeFile.Write(buffer);
    Console.WriteLine(" + "\"" + "写入了{0}字节数据。" + "\"" + @", buffer.Length);
}
using (FileStream readFile = new(" + "\"" + "测试文档.txt" + "\"" + @", FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    byte[] buffer = new byte[1024];
    int size = readFile.Read(buffer);
    string text = Encoding.Default.GetString(buffer, 0, size);
    Console.WriteLine(" + "\"" + @"读出了{0}字节数据，数据是：\n“\n{1}\n”。" + "\"" + @", size, text);
}");
                writeFile.Write(buffer);
                Console.WriteLine("写入了{0}字节数据。", buffer.Length);
            }
            using (FileStream readFile = new("测试文档.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] buffer = new byte[1024];
                int size = readFile.Read(buffer);
                string text = Encoding.Default.GetString(buffer, 0, size);
                Console.WriteLine("读出了{0}字节数据，数据是：\n“\n{1}\n”。", size, text);
            }
        }
    }
}