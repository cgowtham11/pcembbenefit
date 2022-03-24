using EmployeeBenefits.Application.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeBenefits.ApplicationTests
{
    [TestClass]
    public class BenefitDiscountCalculatorTest
    {
        [TestMethod]
        public void NoDiscountBenefitCalculatorTest()
        {
            var target = new NoDiscountBenefitCalculator();
            Assert.AreEqual(1000, target.GetBenefitRate(false));
            Assert.AreEqual(500, target.GetBenefitRate(true));
        }
        [TestMethod]
        public void NameDiscountBenefitCalculatorTest()
        {
            var target = new NameDiscountBenefitCalculator();
            Assert.AreEqual(900, target.GetBenefitRate(false));
            Assert.AreEqual(450, target.GetBenefitRate(true));
        }
    }
}
