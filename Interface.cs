using System;

namespace Interface
{
    public interface Drawable
    {
        void draw();
        void draw2();
    }
    public interface Drawn
    {
        void draw1();
    }
    public class Rectangle : Drawable, Drawn
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
        public void draw2()
        {
            Console.WriteLine("drawing second rectangle...");
        }
        public void draw1()
        {
            Console.WriteLine("drawing first rectangle...");
        }
    }
    public class Interface
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.draw();
            r.draw1();
            r.draw2();

        }
    }

}