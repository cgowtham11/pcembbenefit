using EmployeeBenefits.Application.Service;
using EmployeeBenefits.Domain;
using EmployeeBenefits.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeBenefits.Application.Utility
{
    public class BenefitUtility
    {
        const int PayChecksPerYear = 26;
        public static decimal CalculateAnnualBenefitCost(IBenefitDiscountContext _benefitDiscountContext, Employee employee)
        {
            return _benefitDiscountContext.GetBenefitContext(employee.Name).GetBenefitRate(false) + 
                employee.Dependents.Sum(x => _benefitDiscountContext.GetBenefitContext(employee.Name).GetBenefitRate(true));
        }

        public static List<PayCheckBenefit> CalculatePayCheckCosts(decimal annualBenefitCost)
        {
            var payChecks = new List<PayCheckBenefit>();
            decimal payCheck = Math.Round(annualBenefitCost / PayChecksPerYear, 2);
            for(int i = 1; i<= PayChecksPerYear; i++)
            {
                payChecks.Add(new PayCheckBenefit(i, payCheck));
            }
            var balance = annualBenefitCost - payChecks.Sum(x => x.PayCheckBenefitCost);
            if (balance > 0)
                payChecks[PayChecksPerYear - 1].PayCheckBenefitCost += balance;
            return payChecks;
        }
    }
}
