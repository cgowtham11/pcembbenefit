using EmployeeBenefits.Application.Queries;
using EmployeeBenefits.Application.Utility;
using EmployeeBenefits.Domain;
using EmployeeBenefits.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBenefits.Application.Service
{
    public class EmployeeBenefitService : IEmployeeBenefitService
    {
        private readonly IBenefitDiscountContext _benefitDiscountContext;

        public EmployeeBenefitService(IBenefitDiscountContext benefitDiscountContext)
        {
            _benefitDiscountContext = benefitDiscountContext;
        }

        public async Task<BenifitSummary> ExecuteAsync(Employee employee)
        {
            var benefitSummary = new BenifitSummary(employee)
            {
                AnnualBenefitCost = BenefitUtility.CalculateAnnualBenefitCost(_benefitDiscountContext, employee)
            };
            benefitSummary.PayCheckBenefitCosts = BenefitUtility.CalculatePayCheckCosts(benefitSummary.AnnualBenefitCost);
            return await Task.FromResult(benefitSummary);
        }
    }
}
