using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBenefits.Domain.Model
{
    public class BenifitSummary
    {
        public BenifitSummary(Employee employee)
        {
            Employee = employee;
        }
        public Employee Employee { get; set; }

        public List<PayCheckBenefit> PayCheckBenefitCosts { get; set; }
        public decimal AnnualBenefitCost { get; set; }
    }
    public class PayCheckBenefit
    {
        public PayCheckBenefit(int payCheckId, decimal payCheckBenefitCost)
        {
            PayCheckId = payCheckId;
            PayCheckBenefitCost = payCheckBenefitCost;
        }
        public int PayCheckId { get; set; }
        public decimal PayCheckBenefitCost { get; set; }
    }

}
