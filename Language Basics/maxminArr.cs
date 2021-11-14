// maximum and minimum from an Array

using System;
namespace LanguageBasics
{
    public class maxminArr
    {
        public static void Main(String[] args)
        {
            int max, min, i;
            int[] arr = { 0, 2, -399, 4, -50, 607, 596 };


            max = arr[0];
            min = arr[0];


            for (i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)

                    max = arr[i];

                if (arr[i] < min)

                    min = arr[i];


            }
            Console.WriteLine("MAXIMUM ELEMENT FROM ARRAY IS : " + max);
            Console.WriteLine("MINIMUM ELEMENT FROM ARRAY IS : " + min);
        }
    }
}