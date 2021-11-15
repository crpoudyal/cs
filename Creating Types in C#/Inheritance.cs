using System;

namespace Inheritance
{
    class Inheritance
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.r = 10;
            Console.WriteLine("Area of circle is :" + c.FindCircle());
            c.show();

        }
        class SingleInheritance
        {
            public void show()
            {
                Console.WriteLine("I am inside Single Inheritance");
            }

        }
        class Circle : SingleInheritance
        {
            public int r;

            public double FindCircle()
            {
                return (3.14 * r * r);
            }
        }
    }

}