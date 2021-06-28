using System;

namespace Task
{
    class Employee
    {
        public string firstName, lastName;
        public double salary;
        public Employee() { }
        public Employee(string FirstName, string LastName, double Salary)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.salary = Salary;
        }
        public void ShowFullName()
        {
            Console.WriteLine("Your FullName is : " + firstName + " " + lastName);
            Console.WriteLine("Your Salary is : " + salary);
        }
        public double IncrementSalary(double s)
        {
            double sal = s + salary;
            return sal;
        }

        public static void Main(string[] args)
        {
            Employee emp = new Employee("ram", "bahadur", 20000);
            emp.ShowFullName();
            emp.IncrementSalary(5000);
            emp.firstName = "hari";
            emp.lastName = "bahadur";
            emp.salary = emp.IncrementSalary(5000);
            Console.WriteLine("New salary of " + emp.firstName + " " + emp.lastName + " is : " + emp.salary);
        }
    }
}