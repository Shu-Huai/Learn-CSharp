using System;
namespace Test_Inherit
{
    class TestInherit
    {
        static void Main()
        {
            Person[] persons = new Person[10];
            Random randomGetter = new();
            for (int i = 0; i < persons.Length; i++)
            {
                int number = randomGetter.Next(0, 6);
                switch (number)
                {
                    case 0:
                        persons[i] = new Beast();
                        break;
                    case 1:
                        persons[i] = new Man();
                        break;
                    case 2:
                        persons[i] = new Person();
                        break;
                    case 3:
                        persons[i] = new Student();
                        break;
                    case 4:
                        persons[i] = new Teacher();
                        break;
                    case 5:
                        persons[i] = new Woman();
                        break;
                    default:
                        break;
                }
                persons[i].DescribeSelf();
            }
        }
    }
}