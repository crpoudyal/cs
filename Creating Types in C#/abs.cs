using System;
namespace CreatingTypesInCsharp
{
    abstract class abstr
    {
        public void display()
        {
            Console.WriteLine("I am inside abstract class");
        }
    }
    class Inhrit : abstr
    {
        public void InhritDisplay()
        {
            Console.WriteLine("I am inside Inhrit class");
        }
    }
    public class abs
    {

        public static void Main(String[] args)
        {
            Inhrit Ih = new Inhrit();
            Ih.display();
            Ih.InhritDisplay();
        }
    }
}