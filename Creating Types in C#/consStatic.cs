using System;
namespace CreatingTypesInCsharp
{
    class consStatic
    {
        public consStatic()
        {
            Console.WriteLine("I am normal constructor");
        }
        static consStatic()
        {
            Console.WriteLine("I am static constructor i only be called once ");
        }

        public static void Main(String[] args)
        {
            new consStatic();
            new consStatic();
            new consStatic();

        }
    }
}