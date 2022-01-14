using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiThreading;
using System;
using System.Collections.Generic;
using static MultiThreading.EmployeeDetails;

namespace EmployeePayRollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given5Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Pratiksha", PhoneNumber: "6360384041", Address: "Chikodi", Department: "IT", Gender: 'F', BasicPay: 1000, Deduction: 500, TaxablePay: 100, Tax: 200, NetPay: 2000, City: "Belgaum", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Prerana", PhoneNumber: "6363384041", Address: "Hubli", Department: "IT", Gender: 'F', BasicPay: 2000, Deduction: 400, TaxablePay: 200, Tax: 100, NetPay: 1000, City: "Dharwad", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "Sakshi", PhoneNumber: "6523384041", Address: "Nippani", Department: "IT", Gender: 'F', BasicPay: 5000, Deduction: 600, TaxablePay: 500, Tax: 300, NetPay: 2000, City: "Gokak", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "Darla", PhoneNumber: "63636584041", Address: "Kihaa", Department: "IT", Gender: 'F', BasicPay: 20000, Deduction: 4000, TaxablePay: 2000, Tax: 1000, NetPay: 6000, City: "Seenu", Country: "Maldives"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "Tokyo", PhoneNumber: "6363384635", Address: "Valencia", Department: "IT", Gender: 'F', BasicPay: 200000, Deduction: 40000, TaxablePay: 32000, Tax: 6000, NetPay: 5000, City: "Madrid", Country: "Spain"));

            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            DateTime startDateTime = DateTime.Now; //before excecution
            employeePayrollOperations.addEmployeeToPayroll(employeeDetails);
            DateTime stopdateTime = DateTime.Now; //after execution
            Console.WriteLine("Duration without Thread: " + (startDateTime - startDateTime)); // - operator to get time duration
            
        }
    }
}