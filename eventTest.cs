using System;
namespace Events
{
    public delegate string MyDel(string str);
    class eventTest
    {
        event MyDel MyEvent;
        public eventTest()
        {
            this.MyEvent += new MyDel(WelcomeUser);
        }
        public string WelcomeUser(string msg)
        {
            return "Welcome," + msg;
        }
        static void Main(string[] args)
        {
            eventTest obj1 = new eventTest();
            string result = obj1.MyEvent("Let's Trigger");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}