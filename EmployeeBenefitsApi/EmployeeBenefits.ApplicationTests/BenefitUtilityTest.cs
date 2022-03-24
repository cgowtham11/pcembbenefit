using EmployeeBenefits.Application.Service;
using EmployeeBenefits.Application.Utility;
using EmployeeBenefits.Domain;
using EmployeeBenefits.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeBenefits.ApplicationTests
{
    [TestClass]
    public class BenefitUtilityTest
    {
        private readonly BenefitDiscountContext _benefitDiscountContext;

        public BenefitUtilityTest()
        {
            _benefitDiscountContext = new BenefitDiscountContext(new List<IBenefitCalculator> { new NoDiscountBenefitCalculator(), new NameDiscountBenefitCalculator() });
        }
        [TestMethod]
        public void BenefitUtility_CalculateAnnualBenefitCostTest()
        {
            var employee = new Employee("Aaraon", new List<Dependent>() { new Dependent() { Name = "John", Type=Dependent.DependentType.Spouse }, new Dependent { Name = "Smith", Type = Dependent.DependentType.Child } }, 40000);
            decimal actual = BenefitUtility.CalculateAnnualBenefitCost(_benefitDiscountContext, employee);

            Assert.AreEqual(1800, actual);
        }
        [TestMethod]
        public void BenefitUtility_CalculatePayCheckCostsTest()
        {
            List<PayCheckBenefit> actual = BenefitUtility.CalculatePayCheckCosts(1800);
            Assert.AreEqual(26, actual.Count);
            Assert.AreEqual(1800, actual.Sum(x => x.PayCheckBenefitCost));
        }
    }
}
