using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace webshop.Methods.Tests
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void CalcTotalPriceTest()
        {
            //Arrange 
            List<LineItem> lineItems = new List<LineItem>();
            lineItems.Add(new LineItem(true) { PricePerLine = 6999 });

            //Act
            var sut = new Order(lineItems, "adress", "customer");
            var result = sut.CalcTotalPrice(lineItems);

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void ReturnsPrice()
        {
            //Arrange 
            List<LineItem> lineItems = new List<LineItem>();
            lineItems.Add(new LineItem(true) { PricePerLine = 6999 });

            //Act
            var sut = new Order(lineItems, "adress", "customer");
            var result = sut.CalcTotalPrice(lineItems);

            //Assert
            Assert.AreEqual(lineItems.First().PricePerLine, result);
        }
    }
}