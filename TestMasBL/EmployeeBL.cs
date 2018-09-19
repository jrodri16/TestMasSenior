using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMasDAL;
using static TestMasBL.Enums;

namespace TestMasBL
{
    public class EmployeeBL
    {
        public List<MonthlyEmployee> GetMonthlyEmployees()
        {
            List<Employee> employees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(new ApiAccess().GetEmployees());
            List<MonthlyEmployee> monthlyEmployees = new List<MonthlyEmployee>();
            foreach (var item in employees)
            {
                if (item.ContractTypeName == ContractType.MonthlySalaryEmployee.ToString())
                {
                    monthlyEmployees.Add(new MonthlyEmployee(item));
                }
            }
            return monthlyEmployees;
            
        }

        public List<HourlyEmployee> GetHourlyEmployees()
        {
            List<Employee> employees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(new ApiAccess().GetEmployees());
            List<HourlyEmployee> hourlyEmployees = new List<HourlyEmployee>();
            foreach (var item in employees)
            {
                if (item.ContractTypeName == ContractType.HourlySalaryEmployee.ToString())
                {
                    hourlyEmployees.Add(new HourlyEmployee(item));
                }
            }

            return hourlyEmployees;
        }

        public HourlyEmployee GetHourlyEmployeeById(int id)
        {
            return GetHourlyEmployees().Where(m => m.Id == id).FirstOrDefault();
        }

        public MonthlyEmployee GetMonthlyEmployeeById(int id)
        {
            return GetMonthlyEmployees().Where(m => m.Id == id).FirstOrDefault();
        }
            
            
    }
}
