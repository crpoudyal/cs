using System;
namespace CreatingTypesInCsharp
{
    enum weeks
    {
        sun, mon, tue, wed, thu, fri, sat
    }
    class enums
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Sunday " + "Enum value is " + (int)weeks.sun);
            Console.WriteLine("Monday " + "Enum value is " + (int)weeks.mon);
            Console.WriteLine("Tuesday " + "Enum value is " + (int)weeks.tue);
            Console.WriteLine("Wednesday " + "Enum value is " + (int)weeks.wed);
            Console.WriteLine("Thursday " + "Enum value is " + (int)weeks.thu);
            Console.WriteLine("Friday " + "Enum value is " + (int)weeks.fri);
            Console.WriteLine("Saturday " + "Enum value is " + (int)weeks.sat);
        }
    }
}