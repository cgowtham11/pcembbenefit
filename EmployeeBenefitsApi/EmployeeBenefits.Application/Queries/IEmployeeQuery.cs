using EmployeeBenefits.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeBenefits.Application
{
    public interface IEmployeeQuery
    {
        Task<List<Employee>> ExecuteAsync();
    }
}
