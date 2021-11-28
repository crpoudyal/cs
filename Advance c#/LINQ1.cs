using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvanceCsharp
{
    public class LINQ1
    {
        public static void Main(String[] args)
        {

            string[] arr = { "Krishna", "Mahesh", "Hari", "Sita" };
            // Linq Query
            dynamic Mylinq = from ar in arr
                             where ar.Contains('a')
                             select ar;

            foreach (string ar in Mylinq)
            {
                Console.WriteLine("Name : " + ar);

            }
        }
    }
}