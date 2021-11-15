// We cannot override in sealed class

using System;

namespace CreatingTypesInCsharp
{
    sealed class SealedClass
    {
        public void sclass()
        {
            Console.WriteLine("Inside Sealed class method");

        }

        public static void Main(String[] args)
        {
            SealedClass sc = new SealedClass();
            sc.sclass();
        }


    }

}