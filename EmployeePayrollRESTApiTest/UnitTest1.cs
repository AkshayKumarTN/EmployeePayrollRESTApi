using EmployeePayrollRESTApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace EmployeePayrollRESTApiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OnCallingGET_ReturnEmployeeList()
        {
            // Creating Object of EmployeeWebService to Run Fuctions on them...............
            EmployeeWebService service = new EmployeeWebService();
            // Calling GetEmployeeList which will return IRestResponse...............
            IRestResponse response = service.GetEmployeeList();
            // HttpStatusCode.OK = 200................
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
            // Deserialize JSON Object ..............
            List<Employee> dataResponse = JsonConvert.DeserializeObject<List<Employee>>(response.Content);
            Assert.AreEqual(6, dataResponse.Count);
        }

        [TestMethod]
        public void OnCallingPostAPI_ReturnEmployee()
        {
            EmployeeWebService service = new EmployeeWebService();
            // Employee object is created.............
            Employee employee = new Employee();
            // Adding Values in the Object...................
            employee.name = "John";
            employee.salary = 90000;
            IRestResponse response = service.AddEmployee(employee);
            // Convert the jsonobject to employee object............
            var res = JsonConvert.DeserializeObject<Employee>(response.Content);
            Assert.AreEqual("John", res.name);
            Assert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
        }

        [TestMethod]
        public void OnCallingPostAPI_Adding_MultipleData()
        {
            EmployeeWebService service = new EmployeeWebService();

            List<Employee> employeeList = new List<Employee>();
            // Employee object is created.............
            Employee employee = new Employee();
            // Adding Values in the Object...................
            employee.name = "Watson";
            employee.salary = 88000;
            employeeList.Add(employee);
            employee.name = "Wilson";
            employee.salary = 66000;
            employeeList.Add(employee);
            employee.name = "Phlip";
            employee.salary = 79000;
            employeeList.Add(employee);

            service.AddMultipleEmployee(employeeList);
            IRestResponse response = service.GetEmployeeList();
            // HttpStatusCode.OK = 200................
            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
            // Deserialize JSON Object ..............
            List<Employee> dataResponse = JsonConvert.DeserializeObject<List<Employee>>(response.Content);
            Assert.AreEqual(9, dataResponse.Count);

        }
    }
}
