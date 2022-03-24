using EmployeeBenefits.Application;
using EmployeeBenefits.Application.Queries;
using EmployeeBenefits.Domain;
using EmployeeBenefits.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeBenefitsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeQuery _employeeQuery;
        public readonly IEmployeeBenefitService _employeeBenefitService;

        public EmployeeController(IEmployeeQuery employeeQuery, IEmployeeBenefitService employeeBenefitService)
        {
            _employeeQuery = employeeQuery;
            _employeeBenefitService = employeeBenefitService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Employee>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _employeeQuery.ExecuteAsync());
        }

        [HttpPost]
        [ProducesResponseType(typeof(BenifitSummary), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAsync(Employee employee)
        {
            return Ok(await _employeeBenefitService.ExecuteAsync(employee));
        }
    }
}
