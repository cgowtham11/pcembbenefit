using EmployeeBenefits.Application.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeBenefits.ApplicationTests
{
    [TestClass]
    public class BenefitDiscountContextTest
    {
        private readonly BenefitDiscountContext _benefitDiscountContext;

        public BenefitDiscountContextTest()
        {
            _benefitDiscountContext = new BenefitDiscountContext(new List<IBenefitCalculator> { new NoDiscountBenefitCalculator(), new NameDiscountBenefitCalculator() });
        }
        [TestMethod]
        public void GetBenefitContext_Return_NoDiscountBenefitCalculator_WhenCriteriaMatches()
        {
            var actual = _benefitDiscountContext.GetBenefitContext("Smith");
            Assert.AreEqual(typeof(NoDiscountBenefitCalculator), actual.GetType());
        }
        [TestMethod]
        public void GetBenefitContext_Return_NameDiscountBenefitCalculator_WhenCriteriaMatches()
        {
            var actual = _benefitDiscountContext.GetBenefitContext("Aaron");
            Assert.AreEqual(typeof(NameDiscountBenefitCalculator), actual.GetType());
        }
    }
}
