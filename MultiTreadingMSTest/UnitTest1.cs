using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day36_MultiThreading;
using System.Collections.Generic;
using System;

namespace MultiTreadingMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Bruce", PhoneNumber: "9856253612", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Banner", PhoneNumber: "8795632584", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "clark", PhoneNumber: "8879878585", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "Mike", PhoneNumber: "9632145874", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "Jason", PhoneNumber: "7854125874", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 6, EmployeeName: "Patrick", PhoneNumber: "8741259632", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 7, EmployeeName: "Maria", PhoneNumber: "9898959596", Address: "xyz", Department: "HR", Gender: 'F', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 8, EmployeeName: "Steve", PhoneNumber: "8528528528", Address: "xyz", Department: "HR", Gender: 'M', City: "abc", BasicPay: 100, TaxablePay: 2, Tax: 3, Country: "India"));

            EmployeePayrollOperation employeePayrollOperations = new EmployeePayrollOperation();
            DateTime startDateTime = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with thread: " + (stopDateTimeThread - startDateTimeThread));
            //Assert.AreNotEqual(v1,v2);
        }
    }

}