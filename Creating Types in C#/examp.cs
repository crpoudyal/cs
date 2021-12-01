using System;

namespace CreatingTypesInCsharp
{
    public class Examp
    {
        string name;
        int age;
        String gender;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public void Store(string name, int age, string gender)
        {
            Console.WriteLine("Name is " + name + " Age is " + age + " gender is " + gender);

        }
        public static void Main(String[] args)
        {
            Examp ex = new Examp();
            ex.Store("Hari", 12, "Male");

        }

    }
}