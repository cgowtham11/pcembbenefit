using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBenefits.Application.Service
{

    public interface IBenefitDiscountContext
    {
        IBenefitCalculator GetBenefitContext(string name);
    }

    public class BenefitDiscountContext : IBenefitDiscountContext
    {
        private readonly IEnumerable<IBenefitCalculator> _benefitCalculators;
        public BenefitDiscountContext(IEnumerable<IBenefitCalculator> benefitCalculators)
        {
            _benefitCalculators = benefitCalculators;
        }
        public IBenefitCalculator GetBenefitContext(string name)
        {
            if (!string.IsNullOrWhiteSpace(name) && name.StartsWith("a", StringComparison.InvariantCultureIgnoreCase))
                return _benefitCalculators.Where(s => s.GetType() == typeof(NameDiscountBenefitCalculator)).Single();
            else
                return _benefitCalculators.Where(s => s.GetType() == typeof(NoDiscountBenefitCalculator)).Single();
        }
    }
}
