using System;

namespace AdvanceCsharp
{
    class Gen
    {
        public void sub<T>(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            dynamic sum = a + b;
            Console.WriteLine("Sum : {0} ", sum);
        }

    }
    class GenericMethod : Gen
    {
        static void Main()
        {
            GenericMethod gm = new GenericMethod();
            gm.sub<int>(25, 63);

        }

    }
}