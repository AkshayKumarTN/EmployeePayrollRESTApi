using System;
using System.Collections.Generic;

namespace EmployeePayrollRESTApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Employee Payroll REST Api");
            Console.WriteLine("**********************************************************************************");

            EmployeeWebService employeeWebService = new EmployeeWebService();

            List<Employee> employeeList = new List<Employee>();

            Employee employee = new Employee();
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            // Adding Values in the Object...................
            employee.name = "Watson";
            employee.salary = 88000;
            employeeList.Add(employee);
            employee1.name = "Wilson";
            employee1.salary = 66000;
            employeeList.Add(employee1);
            employee2.name = "Phlip";
            employee2.salary = 79000;
            employeeList.Add(employee2);
            employeeWebService.AddMultipleEmployee(employeeList);
        }
    }
}
