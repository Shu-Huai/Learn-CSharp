using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using Test_Class;
namespace Test_Serialize
{
    class Program
    {
        public static void Main()
        {
            Person person = new("吕陟赫", 18, '男');
            using MemoryStream serializeMemory = new();
            DataContractSerializer serializer = new(typeof(object));
            serializer.WriteObject(serializeMemory, person);
            byte[] data = serializeMemory.ToArray();
            using MemoryStream deserializeMemory = new(data);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(deserializeMemory, new XmlDictionaryReaderQuotas());
            serializer = new(typeof(Person));
            Person result = (Person)serializer.ReadObject(reader, true);
            System.Console.WriteLine(result);
        }
    }
}