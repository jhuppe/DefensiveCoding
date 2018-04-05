using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValid()
        {
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40M;

            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndSame()
        {
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100M;

            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidActualIsZero()
        {
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 0M;

            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            Assert.AreEqual(expected, actual);
        }

    }
}
