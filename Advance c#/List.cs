using System;
using System.Collections.Generic;


namespace AdvanceCsharp
{
    class List
    {
        public static void Main(String[] args)
        {
            List<int> ls = new List<int>();

            ls.Add(2);
            ls.Add(45);
            ls.Add(46);
            ls.Add(12);
            Console.WriteLine("List");
            foreach (var l in ls)
            {
                Console.WriteLine(" " + l);
            }
            ls.Remove(2);
            Console.WriteLine("New List");
            foreach (var l in ls)
            {

                Console.WriteLine(" " + l);
            }

        }
    }
}
