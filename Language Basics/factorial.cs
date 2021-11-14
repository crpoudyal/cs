using System;
namespace LanguageBasics
{
    public class factorial
    {
        public static int Fact(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
        public static void Main()
        {
            Console.WriteLine("Enter a Number");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The Factorial of " + n + " is : " + Fact(n));
        }




    }
}