using System;
namespace Inheritance
{
    public class basekeyword
    {
        public string str = "hello";
        public static void Main(string[] args)
        {
            child ch = new child();
            ch.showPrint();
        }
        public void print()
        {
            Console.WriteLine("I am print Method");
        }
    }
    public class child : basekeyword
    {
        public void showPrint()
        {
            base.print();
            Console.WriteLine(base.str);
        }

    }

}