using System;

namespace cs
{
    class Program
    {

        static void Main(string[] args)
        {

            int a, b;
            Console.Write("Enter any number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter any number: ");
            b = int.Parse(Console.ReadLine());
            int sum = a + b;

            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, sum);



            // Console.WriteLine("Enter any Number");
            // int a = int.Parse(Console.ReadLine());
            // if (a % 2 == 0)
            // {
            //     Console.WriteLine(a + " is even");
            // }
            // else
            // {
            //     Console.WriteLine(a + " is odd");
            // }

        }
    }
}
