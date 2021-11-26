using System;

namespace LanguageBasics
{
    public class arrsum
    {
        public static void Main(String[] args)
        {
            int[] arr = { 12, 12, 3, 4, 0, 78 };
            int i, sum = 0;

            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Index" + " [" + i + "] " + arr[i]);
                sum = sum + arr[i];


            }
            Console.WriteLine("\nSum :" + sum);
        }
    }
}