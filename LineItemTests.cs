using webshop.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System.Collections.Generic;
using System.Linq;

namespace webshop.Methods.Tests
{
    [TestClass()]
    public class LineItemTests
    {

        [TestMethod()]
        public void GetProductForCart()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { ProductId = 1 });


            var method = new LineItem(true);
            var result = method.GetProductForCart(products, true);


            result.ShouldNotBeNull();
        }

        [TestMethod()]
        public void ReturnsProductWithId()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product { ProductId = 1 });

            //Act
            var method = new LineItem(true);
            var result = method.GetProductForCart(products, true);

            //Assert
            result.ProductId.ShouldBe(products.First().ProductId);
        }

        [TestMethod()]
        public void PrintProductLineTest()
        {
            //Arrange
            List<LineItem> lineItems = new List<LineItem>();
            lineItems.Add(new LineItem(true) { ID = 1, ProductName = "Purple Astronaut Suit", Price = 6999, Availability = 10, Quantity = 1, PricePerLine = 6999 });

            //Act
            var sut = new LineItem(true);
            var result = sut.PrintProductLine();

            //Assert
            result.ShouldNotBeEmpty();
        }
    }
}