using System;
using System.Collections;
using System.Collections.Generic;
namespace CollectionType
{
    public class arrayList
    {
        public static void Main(string[] args)
        {
            List();
            ArrList();
        }
        public static void List()
        {
            List<string> names = new List<string>();
            names.Add("Roshan");
            names.Add("Kiran");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
        }
        public static void ArrList()
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("hari");
            al.Add(4.5);
            al.Add(true);
            Console.WriteLine("Total element is : " + al.Count);

        }

    }

}