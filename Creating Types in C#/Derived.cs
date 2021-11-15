using System;
namespace Abstract
{
    abstract class AbsClass
    {
        public abstract void AbsMethod();

        public void examp()
        {
            Console.WriteLine("I am inside abstract class non abstract method");
        }

    }
    class Derived : AbsClass
    {
        public override void AbsMethod()
        {
            Console.WriteLine("Abstract method body in derived class");
        }
        public static void Main(string[] args)
        {
            Derived d = new Derived();
            d.examp();
            d.AbsMethod();


        }
    }

}