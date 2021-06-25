using System;
namespace funoverloading
{
    class funOverloading
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum is : " + sum(2, 3));
            Console.WriteLine("The sum is : " + sum(2, 3, 4));

        }
        static int sum(int a, int b)
        {
            int s = a + b;
            return s;
        }
        static int sum(int a, int b, int c)
        {
            int su = a + b + c;
            return su;
        }
    }
}