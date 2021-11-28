using System;

namespace CreatingTypesInCsharp
{
    public struct sttt
    {
        public sttt(int x)
        {
            Console.WriteLine("X value is " + x);

        }
        public void dis()
        {
            Console.WriteLine("hello");
        }

    }
    public class structt
    {
        static void Main(String[] args)
        {
            sttt s = new sttt(2);
            s.dis();
        }


    }
}