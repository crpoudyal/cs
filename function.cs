using System;

namespace Func
{
    class function
    {
        static void fun1()
        {
            Console.WriteLine("Hello I am Function One");
        }
        static int add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            fun1();
            Console.WriteLine("Sum is : " + add(2, 9));

        }
    }
}