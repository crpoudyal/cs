using System;
namespace oopclass
{
    class oop
    {
        static void Main(string[] args)
        {
            point p = new point();
            p.x = 30;
            p.y = 20;
            p.show();
        }

    }
    class point
    {
        public int x;
        public int y;

        public void show()
        {
            Console.WriteLine("The value of X: " + x);
            Console.WriteLine("The value of Y: " + y);
            Console.WriteLine("The sum is " + (x + y));
        }
    }
}