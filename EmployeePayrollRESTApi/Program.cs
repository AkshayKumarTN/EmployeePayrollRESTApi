using System;

namespace EmployeePayrollRESTApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Employee Payroll REST Api");
            Console.WriteLine("**********************************************************************************");

            EmployeeWebService employeeWebService = new EmployeeWebService();

            Employee employee = new Employee();
            employee.name = "John";
            employee.salary = 90000;

            employeeWebService.AddEmployee(employee);
        }
    }
}
