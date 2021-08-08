using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayrollRESTApi
{
    public class EmployeeWebService
    {
        RestClient client;
        public EmployeeWebService()
        {
            // Creating RestClient Object ................
            client = new RestClient("http://localhost:3000");
        }
        public IRestResponse GetEmployeeList()
        {
            // Creating RestRequest Object with Method.GET................
            RestRequest request = new RestRequest("/employees", Method.GET);
            // Executing request...........
            IRestResponse response = client.Execute(request);
            return response;
        }

        public IRestResponse AddEmployee(Employee employee)
        {
            // Creating RestRequest Object with Method.POST...............
            RestRequest request = new RestRequest("/employees", Method.POST);
            // Creating JsonObject Object to insert values................
            JsonObject json = new JsonObject();
            json.Add("name", employee.name);
            json.Add("salary", employee.salary);
            // Adding into JSON file..............
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            // Executing request...........
            IRestResponse response = client.Execute(request);
            return response;
        }
        public void AddMultipleEmployee(List<Employee> employeeList)
        {
            EmployeeWebService employeeWebService = new EmployeeWebService();
            // Creating RestRequest Object with Method.POST...............
            RestRequest request = new RestRequest("/employees", Method.POST);
            foreach (Employee employee in employeeList)
            {
                employeeWebService.AddEmployee(employee);
            }
        }
    }
}
