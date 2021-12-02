using System;

namespace AdvanceCsharp
{
    public delegate void Mydelegate(String name);
    public class AnonymousMethod
    {
        public static void Main()
        {
            Mydelegate md = delegate (String name)
            {
                Console.WriteLine("My name is " + name);
            };
            md.Invoke("Rj Poudyal");
        }
    }
}