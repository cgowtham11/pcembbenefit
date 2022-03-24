using EmployeeBenefits.Domain;
using EmployeeBenefits.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBenefits.Application.Queries
{
    public interface IEmployeeBenefitService
    {
        Task<BenifitSummary> ExecuteAsync(Employee employee);
    }
}
