using System;
namespace CreatingTypesInCsharp
{
    class consOverloaded
    {
        public consOverloaded(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("sum is {0}", sum);
        }
        public consOverloaded()
        {
            Console.WriteLine("I am parameter less constructor");

        }

        public static void Main(String[] args)
        {
            new consOverloaded();
            new consOverloaded(4, 5);
        }
    }
}