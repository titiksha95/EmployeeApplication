using System;

namespace EmployeeManagementSystem.Models
{
    public class PermanentEmployee : Employee
    {
        public double BasicSalary { get; set; }
        public double HRA { get; set; }
        public double Bonus { get; set; }

        public override double CalculateSalary()
        {
            return BasicSalary + HRA + Bonus;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Permanent Employee");
            Console.WriteLine($"ID : {EmployeeId}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Department : {Department}");
            Console.WriteLine($"Salary : {CalculateSalary()}");
        }
    }
}