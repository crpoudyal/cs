using System;
namespace LanguageBasics
{
    public class largestSmallest
    {


        public static void Main(String[] args)
        {
            double a = 0.40;
            double b = 1.50;
            int c = -10;
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is largest");

            }
            else if (b > a && b > c)
            {

                Console.WriteLine(b + " is largest");

            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c + " is largest");

            }
            if (a < b && a < c)
            {
                Console.WriteLine(a + " is smallest");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b + " is smallest");
            }
            if (c < a && c < b)
            {
                Console.WriteLine(c + " is smallest");
            }
        }


    }
}