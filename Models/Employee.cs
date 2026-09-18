using System;

namespace EmployeeManagementSystem.Models
{
    public abstract class Employee
    {
        private static int nextId = 1001;

        public int EmployeeId { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public Employee()
        {
            EmployeeId = nextId++;
        }

        public abstract double CalculateSalary();
        public abstract void DisplayDetails();
    }
}