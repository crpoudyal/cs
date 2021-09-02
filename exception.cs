using System;

namespace ExpHandling
{
    class exception
    {

        public static void exp()
        {
            try
            {
                int a = 10, b = 0;
                int[] arr = { 10, 20, 30 };
                Console.WriteLine(arr[5]);
                Console.WriteLine(a / b);

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array IndexOut of Range", ex);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted to divide by zero.", e);
            }

            finally
            {
                Console.WriteLine("Remaining codes");
            }
        }
        static void Main(string[] args)
        {
            exp();
        }
    }
}
