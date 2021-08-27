using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQ
{
    class LINQsql
    {
        static void Main(string[] args)
        {
            List<string> myBooks = new List<string>(){
                "C# Tutorials","VB.NET Tutorials","C#","C++","C"
            };
            // LINQ query syntax
            var result = from s in myBooks
                         where s.Contains("Tutorials")
                         select s;
            // LINQ Method syntax
            var res = myBooks.Where(s => s.Contains("Tutorials"));
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }

}