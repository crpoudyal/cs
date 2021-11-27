using System;

namespace CreatingTypesInCsharp
{
    class Test
    {
        string name = "ram";
        public virtual void display()
        {
            Console.WriteLine("I am parent Method ");

        }
        public static void xy()
        {
            Console.WriteLine("I am xy method");
        }
        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;

            }
        }

    }
    class sealedMethod : Test
    {
        string name = "hari";
        public string Names
        {
            get
            {
                return name;

            }
            set
            {
                name = value;

            }
        }

        public override sealed void display()
        {
            Console.WriteLine("I am overriden method with sealed modifier");
            Console.WriteLine("Name is " + base.Name);
        }

    }
    class method : sealedMethod
    {
        // public override sealed void display(){ 
        // }
        // 'method.display()': cannot override inherited member 'sealedMethod.display()' because it is sealed
        public static void Main()
        {
            sealedMethod sm = new sealedMethod();
            sm.display();


        }
    }
}