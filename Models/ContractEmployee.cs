using System;

namespace EmployeeManagementSystem.Models
{
    public class ContractEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Contract Employee");
            Console.WriteLine($"ID : {EmployeeId}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Department : {Department}");
            Console.WriteLine($"Salary : {CalculateSalary()}");
        }
    }
}