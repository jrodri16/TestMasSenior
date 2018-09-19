using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TestMasDAL
{
    public class ApiAccess
    {
        static string url = "http://masglobaltestapi.azurewebsites.net/api/";

        public string GetEmployees()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            string jsonEmployees = "";
            // List data response.
            HttpResponseMessage response = client.GetAsync("Employees").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                jsonEmployees = "[{\"id\":1,\"name\":\"Juan\",\"contractTypeName\":\"HourlySalaryEmployee\",\"roleId\":1,\"roleName\":\"Administrator\",\"roleDescription\":null,\"hourlySalary\":60000,\"monthlySalary\":80000},{\"id\":2,\"name\":\"Sebastian\",\"contractTypeName\":\"MonthlySalaryEmployee\",\"roleId\":2,\"roleName\":\"Contractor\",\"roleDescription\":null,\"hourlySalary\":60000,\"monthlySalary\":80000}]";
                //jsonEmployees = response.Content.ToString();
               
            }
            //Make any other calls using HttpClient here.

            //Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();

            return jsonEmployees;
        }
    }
}
