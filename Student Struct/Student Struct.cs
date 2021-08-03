using System;
namespace Student_Struct
{
    public enum Gender
    {
        男,
        女
    }
    public struct Student
    {
        public string name_;
        public int age_;
        public Gender gender_;
    }
    class StudentStruct
    {
        static void Main()
        {
            Student me;
            me.name_ = "吕陟赫";
            me.age_ = 20;
            me.gender_ = Gender.男;
        }
    }
}