using System;

namespace IndexerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("EMP0111", "Director", "Bob",
                "Tim", 8000);
            emp[2] = "Bobby";
            Console.WriteLine(emp[0]);
            Console.WriteLine(emp[1]);
            Console.WriteLine(emp[2]);
            Console.WriteLine(emp[3]);
            Console.WriteLine(emp[4]);
            emp["salary"] = 80000;
            Console.WriteLine("Employee Number :" + emp["empNumber"]);
            Console.WriteLine("Employee Title :" + emp["jobTitle"]);
            Console.WriteLine("Employee Name :" + emp["name"]);
            Console.WriteLine("Employee Surname :" + emp["surname"]);
            Console.WriteLine("Employee Salary :" + emp["salary"]);
        }
    }
}
