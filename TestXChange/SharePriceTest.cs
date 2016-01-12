using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockHelper;

namespace TestXChange
{
    [TestClass]
    public class SharePriceTest
    {
        [TestMethod]
        public void SharePriceExists()
        {
            SharePrice sp = new SharePrice();
            Assert.IsNotNull(sp, "Het is niet gelukt shareprice te instantiëren");
        }
        [TestMethod]
        public void SharePriceValueExists()
        {
            SharePrice sp = new SharePrice();
            float result = sp.getActualSharePrice("TSLA");
            Assert.IsTrue(result > 10 && result < 1000, "Dit is geen geloofwaardige waarde");
            Assert.IsFalse(result == 0, "Helemaal niks!");
        }
    }
}
