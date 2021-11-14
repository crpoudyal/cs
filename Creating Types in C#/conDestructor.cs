using System;

namespace CreatingTypesInCsharp
{
    public class conDestructor
    {
        public conDestructor(int a, int b)
        {
            int sum = a + b;

            Console.WriteLine("sum is : " + sum);
        }

        ~conDestructor()
        {
            Console.WriteLine("I am Destructor");

        }


        public static void Main(String[] args)
        {
            conDestructor CD = new conDestructor(20, 30);

        }


    }
}