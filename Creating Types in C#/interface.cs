using System;

namespace CreatingTypesInCsharp
{
    class ineterface
    {
        public static void Main(String[] args)
        {
            Iclass IC = new Iclass();
            IC.IclassMethod();
            IC.Imethod();
        }
    }
    interface Iface
    {
        void Imethod();

    }
    class Iclass : Iface
    {
        public void Imethod()
        {
            Console.WriteLine("I am interface Method I method");
        }
        public void IclassMethod()
        {
            Console.WriteLine("I am I class Method");
        }
    }
}