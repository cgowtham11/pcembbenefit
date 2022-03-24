using EmployeeBenefits.Application;
using EmployeeBenefits.Domain;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeBenefits.Infrastructure
{
    public class EmployeeQueryHandler : IEmployeeQuery
    {
        private readonly IRepository _employeeRepository;
        public EmployeeQueryHandler(IRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<List<Employee>> ExecuteAsync()
        {
            return await _employeeRepository.GetEmployees();
        }
    }
}
