using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CafeXLogic;

namespace CafeXTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Calculate_CorrectValue_True()
        {
            //Arrange
            var expectedValue = 3.50;
            var cola = new CafeMenuItem() { Name = "Cola", Price = 0.50 };
            var coffee = new CafeMenuItem() { Name = "Coffee", Price = 1.00 };
            var cheeseSandwich = new CafeMenuItem() { Name = "Cheese Sandwich", Price = 2.00 };
            //Act
            var result = cola.Price + coffee.Price + cheeseSandwich.Price;
            //Assert
            Assert.AreEqual(result, expectedValue);
        }

        [TestMethod]
        public void Calculate_CorrectValue_False()
        {
            //Arrange
            var expectedValue = 4.5;
            var cola = new CafeMenuItem() { Name = "Cola", Price = 0.50 };
            var coffee = new CafeMenuItem() { Name = "Coffee", Price = 1.00 };
            var cheeseSandwich = new CafeMenuItem() { Name = "Cheese Sandwich", Price = 0.50 };
            //Act
            var result = cola.Price + coffee.Price + cheeseSandwich.Price;
            //Assert
            Assert.AreNotEqual(result, expectedValue);
        }
    }
}
