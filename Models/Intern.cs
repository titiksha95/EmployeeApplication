using System;

namespace EmployeeManagementSystem.Models
{
    public class Intern : Employee
    {
        public double Stipend { get; set; }

        public override double CalculateSalary()
        {
            return Stipend;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Intern");
            Console.WriteLine($"ID : {EmployeeId}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Department : {Department}");
            Console.WriteLine($"Salary : {CalculateSalary()}");
        }
    }
}