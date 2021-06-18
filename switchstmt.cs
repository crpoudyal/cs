using System;

namespace switchh
{
    class switchstmt
    {

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter any Number");
            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Write("One");
                    break;
                case 2:
                    Console.Write("Two");
                    break;
                case 3:
                    Console.Write("Three");
                    break;
                case 4:
                    Console.Write("Four");
                    break;
                default:
                    Console.Write("out of range");
                    break;
            }
        }
    }
}
