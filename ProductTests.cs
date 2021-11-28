using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System.Collections.Generic;
using System.Linq;

namespace webshop.Methods.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void ProductsTest()
        {
            //Arrange
            List<Product> products = new List<Product>();
            products.Add(new Product { ProductId = 1, Name = "Purple Astronaut Suit", Price = 6999});

            //Act
            var sut = new Product();
            var result = sut.PrintProducts();

            //Assert
            result.ShouldNotBeEmpty();
        }
    }
}