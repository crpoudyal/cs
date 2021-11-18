using System;

namespace CreatingTypesInCsharp
{

    class parent
    {
        public virtual void meth()
        {
            Console.WriteLine("I am Parent method");
        }
    }

    class funoverloading : parent
    {
        public override void meth()
        {
            Console.WriteLine("I am overrided method");
        }
        public static void Main(String[] args)
        {

            funoverloading fo = new funoverloading();
            fo.meth();
            parent p = new parent();
            p.meth();
        }
    }
}