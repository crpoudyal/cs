using System;
using System.Collections.Generic;
using System.Linq;
namespace Lamda
{
    class LamdaExp
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //using lamda expression
            var square = numbers.Select(x => x * x);
            Console.Write("Square:");
            foreach (var value in square)
            {
                Console.Write("{0}", value);
            }
        }
    }
}