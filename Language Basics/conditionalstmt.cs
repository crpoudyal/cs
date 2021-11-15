using System;

namespace conditionalstm
{
    class Conditionalstmt
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int inp = int.Parse(Console.ReadLine());
            if (inp < 0)
            {
                Console.WriteLine("Negative");
            }
            else if (inp > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Equal to Zero");
            }
        }
    }
}
