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
            client = new RestClient("http://localhost:3000");
        }
        public IRestResponse GetEmployeeList()
        {
            RestRequest request = new RestRequest("/employees", Method.GET);
            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}
