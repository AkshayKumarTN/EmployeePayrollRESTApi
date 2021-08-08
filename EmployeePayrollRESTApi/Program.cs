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
            employee.name = "Watson";
            employee.salary = 88000;
            employeeList.Add(employee);
            employee.name = "Wilson";
            employee.salary = 66000;
            employeeList.Add(employee);
            employee.name = "Phlip";
            employee.salary = 79000;
            employeeList.Add(employee);

            employeeWebService.AddMultipleEmployee(employeeList);
        }
    }
}
