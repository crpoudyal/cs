using System;

namespace AdvanceCsharp
{
    public delegate void AddDelegate(int x, int y);
    public delegate void SubDelegate(int x, int y, int z);

    class DelegateClass
    {
        public void add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum : {0}", sum);
        }
        public static void sub(int a, int b, int c)
        {
            int sub = a - b - c;
            Console.WriteLine("Sum : {0}", sub);
        }
    }
    class Delegate : DelegateClass
    {
        static void Main()
        {
            DelegateClass dc = new DelegateClass();
            AddDelegate ad = new AddDelegate(dc.add);
            SubDelegate sd = new SubDelegate(DelegateClass.sub);
            ad(20, 20);
            sd.Invoke(23, 78, 0);
        }
    }
}