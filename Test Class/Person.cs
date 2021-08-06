using System;
namespace Test_Class
{
    public class Person
    {
        private int age_;
        private char gender_;
        public string Name { get; set; }
        public int Age
        {
            get => age_;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                age_ = value;
            }
        }
        public char Gender
        {
            get => gender_;
            set
            {
                if (value != '男' && value != '女')
                {
                    value = '\0';
                }
                gender_ = value;
            }
        }
        public Person(string name = "", int age = 0, char gender = '\0')
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public static void SayHello()
        {
            Console.WriteLine("你好。");
        }
        public override string ToString()
        {
            return $"{Name}，{Age}，{Gender}。";
        }
    }
}