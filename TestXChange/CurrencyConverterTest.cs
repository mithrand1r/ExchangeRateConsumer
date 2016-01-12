using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockHelper;

namespace TestXChange
{
    [TestClass]
    public class TestCurrency
    {
        [TestMethod]
        public void EurToEur()
        {
            ExchangeRateCalculator ERC = new ExchangeRateCalculator();
            Converter result=ERC.Convert(4,"EUR", "EUR");
            Assert.AreEqual(4, result.amount, "Niet echt hetzelfde hè");
        }
    }

}
