using System;

namespace AdvanceCsharp
{
    class Generic<T>
    {
        public void fun(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            dynamic sum = d1 + d2;
            Console.WriteLine("Sum : {0} ", sum);

        }
    }
    class GenericsUse
    {
        static void Main(String[] args)
        {
            Generic<int> g = new Generic<int>();
            g.fun(20, 30);
        }
    }

}