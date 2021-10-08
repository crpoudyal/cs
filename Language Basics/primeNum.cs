using System;
namespace LanguageBasics
{
    class primeNum
    {
        public static void Main(String[] args)
        {
            int a = 4;
            int c = 0;
            for (int i = 1; i < 100; i++)
            {
                if (a % i == 0)
                {
                    c++;
                }
            }
            if (c == 2)
            {
                Console.WriteLine(a + " is prime number");
            }
            else
            {
                Console.WriteLine(a + " is not prime number");
            }

        }
    }
}