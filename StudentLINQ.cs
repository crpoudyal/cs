using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class StudentLINQ
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class LINQTest
    {
        static void Main(String[] args)
        {
            List<StudentLINQ> StudentList = new List<StudentLINQ>()
            {
                new StudentLINQ {StudentId=1,StudentName="Hari",Age=20},
                new StudentLINQ {StudentId=2,StudentName="Gopal",Age=18},
                new StudentLINQ {StudentId=3,StudentName="Shyam",Age=17},
                new StudentLINQ {StudentId=4,StudentName="Roshan",Age=13}

            };
            var teenAgerStudent = from s in StudentList
                                  where s.Age > 12 && s.Age < 20
                                  select s;
            foreach (StudentLINQ s1 in teenAgerStudent)
                Console.WriteLine(s1.StudentName);
        }
    }

}