using System;
using System.Collections.Generic;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine("Employee Added Successfully.");
        }

        public void DisplayEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No Employees Found.");
                return;
            }

            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();
            }
        }

        public void SearchEmployee(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.EmployeeId == id)
                {
                    emp.DisplayDetails();
                    return;
                }
            }

            Console.WriteLine("Employee Not Found.");
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = null;

            foreach (Employee emp in employees)
            {
                if (emp.EmployeeId == id)
                {
                    employee = emp;
                    break;
                }
            }

            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine("Employee Deleted.");
            }
            else
            {
                Console.WriteLine("Employee Not Found.");
            }
        }
    }
}