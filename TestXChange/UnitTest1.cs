using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter;

namespace TestXChange
{
    [TestClass]
    public class TestCurrency
    {
        [TestMethod]
        public void EurToEur()
        {
            Converter result=ExchangeRateCalculator.Convert(4,"EUR", "EUR");
            Assert.AreEqual(4, result.amount, "Niet echt hetzelfde hè");
        }
        [TestMethod]
        public void GBPtoEur()
        {
            Converter result=ExchangeRateCalculator.Convert(1,"GBP", "EUR");
            Assert.IsNotNull(result, "Er komt niks terug!");
            Assert.IsTrue(result.rate>1,string.Format("Hoe kan dat, is de GBP kleiner dan de Eur? De rate is {0}",result.rate));
        }
    }

}
