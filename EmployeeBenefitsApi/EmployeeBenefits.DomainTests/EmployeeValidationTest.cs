using EmployeeBenefits.Domain;
using EmployeeBenefits.Domain.Exception;
using EmployeeBenefits.Domain.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EmployeeBenefits.DomainTests
{
    [TestClass]
    public class EmployeeValidationTest
    {
        [TestMethod]
        public void ValidateEmployeeValidation()
        {
            var employee = new Employee();
            Assert.IsFalse(EmployeeValidation.ValidateEmployee(employee.Name, employee.AnnualPay, employee.Dependents, out string exceptionMessage));
            employee = new Employee("A", new List<Dependent>(), 1000);
            Assert.IsTrue(EmployeeValidation.ValidateEmployee(employee.Name, employee.AnnualPay, employee.Dependents, out exceptionMessage));
        }
        [TestMethod]
        [ExpectedException(typeof(InValidEmployeeException))]
        public void CreateEmployee_ThrowsError_WhenNotValid()
        {
            var employee = new Employee(string.Empty, null, 0);
        }
    }
}
