using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMasBL
{
    public class HourlyEmployee : Employee, ITypeSalary
    {
        public int AnnualHourlySalary { get; set; }

        public HourlyEmployee(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.ContractTypeName = employee.ContractTypeName;
            this.RoleId = employee.RoleId;
            this.RoleName = employee.RoleName;
            this.RoleDescription = employee.RoleDescription;
            this.MonthlySalary = employee.HourlySalary;
            this.AnnualHourlySalary = CalculateAnnualSalary(employee.HourlySalary);
        }

        public int CalculateAnnualSalary(int baseSalary)
        {
            return base.HourlySalary * 12 * 120;
        }
    }
}
