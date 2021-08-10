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
                        ((Beast)persons[i]).DescribeSelf();
                        break;
                    case 1:
                        persons[i] = new Man();
                        ((Man)persons[i]).DescribeSelf();
                        break;
                    case 2:
                        persons[i] = new Person();
                        persons[i].DescribeSelf();
                        break;
                    case 3:
                        persons[i] = new Student();
                        ((Student)persons[i]).DescribeSelf();
                        break;
                    case 4:
                        persons[i] = new Teacher();
                        ((Teacher)persons[i]).DescribeSelf();
                        break;
                    case 5:
                        persons[i] = new Woman();
                        ((Woman)persons[i]).DescribeSelf();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}