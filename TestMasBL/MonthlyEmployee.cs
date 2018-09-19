using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMasBL
{
    public class MonthlyEmployee : Employee, ITypeSalary
    {
        public int AnnualMonthSalary { get; set; }

        public MonthlyEmployee(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.ContractTypeName = employee.ContractTypeName;
            this.RoleId = employee.RoleId;
            this.RoleName = employee.RoleName;
            this.RoleDescription = employee.RoleDescription;
            this.MonthlySalary = employee.MonthlySalary;           
            this.AnnualMonthSalary = CalculateAnnualSalary(employee.MonthlySalary);
        }
        
        public int CalculateAnnualSalary(int baseSalary)
        {
            return baseSalary * 12;
        }
    }
}
