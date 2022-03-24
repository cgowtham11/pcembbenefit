using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeBenefits.Application;
using System.Threading.Tasks;
using System.Collections.Generic;
using EmployeeBenefits.Domain;
using EmployeeBenefits.Application.Queries;
using EmployeeBenefitsApi.Controllers;

namespace EmployeeBenefits.Api
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public async Task GetEmployeeAsyncTest()
        {
            //Arrange
            var target = new EmployeeController(new MockEmployeeQuery(), null);

            //Act
            var actual = await target.GetAsync();

            //Assert
            Assert.IsNotNull(actual);
        }
        public class MockEmployeeQuery : IEmployeeQuery
        {
            public Task<List<Employee>> ExecuteAsync()
            {
                return Task.FromResult(new List<Employee>());
            }
        }
    }
}
