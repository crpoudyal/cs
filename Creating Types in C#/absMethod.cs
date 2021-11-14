using System;
namespace CreatingTypesInCsharp
{

    abstract class A
    {
        public abstract void xyz();
        public void pqr()
        {
            Console.WriteLine("I am abstract class Method");
        }

    }
    class B : A
    {
        public override void xyz()
        {
            Console.WriteLine("I am overridden Method from abstract class");
        }
    }
    class absMethod
    {
        public static void Main(String[] args)
        {
            B B = new B();
            B.xyz();
            B.pqr();
        }
    }
}