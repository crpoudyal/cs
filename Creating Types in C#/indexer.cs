using System;

namespace CreatingTypesInCsharp
{
    class index
    {
        int Eno;
        String Ename, Elocation;

        public index(int Eno, String Ename, String Elocation)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Elocation = Elocation;
        }
        public object this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return Eno;
                }
                else if (i == 1)
                {
                    return Ename;
                }
                else if (i == 2)
                {
                    return Elocation;
                }
                return 0;
            }
            set
            {
                if (i == 0)
                {
                    Eno = (int)value;
                }
                else if (i == 1)
                {
                    Ename = (string)value;
                }
                else if (i == 2)
                {
                    Elocation = (String)value;
                }

            }
        }
    }
    class indexer
    {
        public static void Main(String[] args)
        {
            index ind = new index(200, "Ram", "Biratnagar");
            Console.WriteLine("Employee No : " + ind[0]);
            Console.WriteLine("Employee Name : " + ind[1]);
            Console.WriteLine("Employee Location : " + ind[2]);

            ind[1] = "Krishna";

            Console.WriteLine("Employee Name after modifing: " + ind[1]);


        }
    }
}