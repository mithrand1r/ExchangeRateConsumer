using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter;

namespace TestXChange
{
    [TestClass]
    public class TestCurrency
    {
        [TestMethod]
        public void GBPtoEur()
        {
            float result=ExchangeRateCalculator.Convert(4,"EUR", "EUR");
            Assert.AreEqual(4, result, "Niet echt hetzelfde hè");
        }
    }
}
