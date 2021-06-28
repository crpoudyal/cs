using System;
namespace Inheritance
{
    class Constructinheritance
    {
        public static void Main(string[] args)
        {
            Child c = new Child();
            c.show();


        }
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("I am Parent Constructor");
            }
            public void show()
            {
                Console.WriteLine("I am parent method");
            }
        }
        class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("I am child constructor");
            }
        }
    }
}