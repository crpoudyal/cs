using System;
namespace Array
{
    class arr
    {
        static void Main(String[] args)
        {
            int sum = 0;
            int[] arr = { 2, 3, 5, 6, 7, 2 };

            foreach (int j in arr)
            {
                sum = sum + j;
            }
            Console.WriteLine(sum);

        }
    }
}

//Array with Foreach Loop