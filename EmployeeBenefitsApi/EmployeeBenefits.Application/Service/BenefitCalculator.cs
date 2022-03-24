using EmployeeBenefits.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeBenefits.Application.Service
{
    public interface IBenefitCalculator
    {
        public decimal GetBenefitRate(bool isDependent);
    }
    public abstract class BenefitDiscountCalculator
    {
        private const int EmployeeBenefitCost = 1000;
        private const int DependentBenefitCost = 500;
        public decimal DiscountRate = 0;
        public decimal GetBenefitRate(bool isDependent)
        {
            decimal benefitCost = isDependent ? DependentBenefitCost : EmployeeBenefitCost;
            return benefitCost - (benefitCost / 100) * DiscountRate;
        }
    }
    public class NoDiscountBenefitCalculator : BenefitDiscountCalculator, IBenefitCalculator
    {
        public new decimal GetBenefitRate(bool isDependent)
        {
            return base.GetBenefitRate(isDependent);
        }
    }

    public class NameDiscountBenefitCalculator :  BenefitDiscountCalculator, IBenefitCalculator
    {
        public NameDiscountBenefitCalculator()
        {
            DiscountRate = 10;
        }
        public new decimal GetBenefitRate(bool isDependent)
        {
            return base.GetBenefitRate(isDependent);
        }
    }
}
