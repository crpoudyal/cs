using System;

namespace AdvanceCsharp
{

    public delegate void mydel();
    public class Multicast
    {
        public void display()
        {
            Console.WriteLine("Display method");
        }
        public void display1()
        {
            Console.WriteLine("Display1 method");
        }
    }
    public class MulticastDelegets : Multicast
    {
        static void Main()
        {
            Multicast mc = new Multicast();

            mydel md = mc.display;
            md += mc.display1;
            md.Invoke();

        }



    }

}