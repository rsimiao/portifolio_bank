using com.gft.creditSuisse.Domain.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace com.gft.creditSuisse.Domain.UnitTests
{
    [TestFixture]
    class MediumRiskStrategyTests
    {
        [TestCase(100_000)]
        [TestCase(999_999)]
        [TestCase(-100.29)]
        public void LowRisk_PublicAndLessThanMilion_returnLowRiskIsTrue(double valor)
        {
            var t = new Trade() { Value = valor, ClientSector = "Public" };
            var risk = ContextRisk.Get(t).Categorize();

            Assert.AreEqual("LOWRISK", risk);
        }

        [TestCase(1_000_000.89)]
        [TestCase(2_000_000)]
        public void LowRisk_ValueGreaterThanMilion_returnMediumRiskIsTrue(double valor)
        {
            var t = new Trade() { Value = valor, ClientSector = "Public" };
            var risk = ContextRisk.Get(t).Categorize();
           
            Assert.AreEqual("MEDIUMRISK", risk);
        }

        [TestCase(1_000_000)]
        [Ignore("Na documentação não tem uma ação para quando for 1.000.000")]
        public void LowRisk_ValueEqualMilion_returnRiskNotFound(double valor)
        {
            var t = new Trade() { Value = valor, ClientSector = "Public" };
            var risk = ContextRisk.Get(t).Categorize();
            Assert.AreEqual("NOTFOUND", risk);
        }

    
    }
}
