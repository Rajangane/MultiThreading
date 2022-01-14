using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class EmployeePayrollOperations
    {
        /// <summary>
        /// UC1 : non thread
        /// </summary>
        public List<EmployeeDetails> employeePayrollDetailList = new List<EmployeeDetails>();
        public void addEmployeeToPayroll(List<EmployeeDetails>employeePayrollDetails)
        {
            employeePayrollDetailList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine("Employee Added: " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.employeePayrollDetailList.ToString());

        }
        public void addEmployeePayroll(EmployeeDetails emp)
        {
            employeePayrollDetailList.Add(emp);
        }
    }
}
