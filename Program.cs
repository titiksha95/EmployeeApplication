using System;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using EmployeeManagementSystem.Utilities;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();

            while (true)
            {
                Console.WriteLine("\n===== Employee Management System =====");
                Console.WriteLine("1. Add Permanent Employee");
                Console.WriteLine("2. Add Contract Employee");
                Console.WriteLine("3. Add Intern");
                Console.WriteLine("4. Display Employees");
                Console.WriteLine("5. Search Employee");
                Console.WriteLine("6. Delete Employee");
                Console.WriteLine("7. Exit");

                int choice = Validation.ReadInt("Enter Choice: ");

                switch (choice)
                {
                    case 1:
                        PermanentEmployee p = new PermanentEmployee();

                        Console.Write("Enter Name: ");
                        p.Name = Console.ReadLine();

                        p.Age = Validation.ReadInt("Enter Age: ");

                        Console.Write("Enter Department: ");
                        p.Department = Console.ReadLine();

                        p.BasicSalary = Validation.ReadDouble("Enter Basic Salary: ");
                        p.HRA = Validation.ReadDouble("Enter HRA: ");
                        p.Bonus = Validation.ReadDouble("Enter Bonus: ");

                        manager.AddEmployee(p);
                        break;

                    case 2:
                        ContractEmployee c = new ContractEmployee();

                        Console.Write("Enter Name: ");
                        c.Name = Console.ReadLine();

                        c.Age = Validation.ReadInt("Enter Age: ");

                        Console.Write("Enter Department: ");
                        c.Department = Console.ReadLine();

                        c.HourlyRate = Validation.ReadDouble("Enter Hourly Rate: ");
                        c.HoursWorked = Validation.ReadInt("Enter Hours Worked: ");

                        manager.AddEmployee(c);
                        break;

                    case 3:
                        Intern i = new Intern();

                        Console.Write("Enter Name: ");
                        i.Name = Console.ReadLine();

                        i.Age = Validation.ReadInt("Enter Age: ");

                        Console.Write("Enter Department: ");
                        i.Department = Console.ReadLine();

                        i.Stipend = Validation.ReadDouble("Enter Stipend: ");

                        manager.AddEmployee(i);
                        break;

                    case 4:
                        manager.DisplayEmployees();
                        break;

                    case 5:
                        int id = Validation.ReadInt("Enter Employee ID: ");
                        manager.SearchEmployee(id);
                        break;

                    case 6:
                        id = Validation.ReadInt("Enter Employee ID: ");
                        manager.DeleteEmployee(id);
                        break;

                    case 7:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
            }
        }
    }
}