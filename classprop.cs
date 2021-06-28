using System;
namespace classp
{
    class classprop
    {
        static void Main(string[] args)
        {
            point p = new point();
            p.X = 30;
            p.Y = 20;
            p.show();
        }

    }
    class point
    {
        private int x;
        private int y;
        public int X
        {
            get { return x; }
            set { x = value; }

        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public void show()
        {
            Console.WriteLine("The value of X: " + x);
            Console.WriteLine("The value of Y: " + y);
        }
    }
}