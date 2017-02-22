using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CafeXLogic;

namespace CafeXTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CalculateTotalBill_CorrectValue_True()
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
        public void CalculateTotalBill_CorrectValue_False()
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

        [TestMethod]
        public void CalculateServiceCharge_HotFood_True()
        {
            //Arrange
            var cola = new CafeMenuItem() { Name = "Cola", Price = 0.50 };
            var coffee = new CafeMenuItem() { Name = "Coffee", Price = 1.00 };
            var steakSandwich = new CafeMenuItem() { Name = "Steak Sandwich", Price = 0.50, IsHot = true };
            var expectedValue = 0.40;

            //Act
            var result = (cola.Price + coffee.Price + steakSandwich.Price) * 0.20;

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void CalculateServiceCharge_HotFood_False()
        {
            //Arrange
            var cola = new CafeMenuItem() { Name = "Cola", Price = 0.50 };
            var coffee = new CafeMenuItem() { Name = "Coffee", Price = 1.00 };
            var steakSandwich = new CafeMenuItem() { Name = "Steak Sandwich", Price = 4.50, IsHot = true };
            var expectedValue = 1.20;

            //Act
            var result = (cola.Price + coffee.Price + steakSandwich.Price) * 0.20;

            //Assert
            Assert.AreNotEqual(expectedValue, result);
        }

        [TestMethod]
        public void CalculateServiceCharge_JustDrinks_True()
        {
            //Arrange
            var cola = new CafeMenuItem() { Name = "Cola", Price = 0.50 };
            var coffee = new CafeMenuItem() { Name = "Coffee", Price = 1.00 };            
            var expectedValue = 0.00;

            //Act
            var result = (cola.Price + coffee.Price) * 0.00;

            //Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void CalculateServiceCharge_JustDrinks_False()
        {
            //Arrange
            var cola = new CafeMenuItem() { Name = "Cola", Price = 0.50 };
            var coffee = new CafeMenuItem() { Name = "Coffee", Price = 1.00 };            

            //Act
            var result = (cola.Price + coffee.Price) * 0.00;

            //Assert
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void CalculateServiceCharge_ColdFood_True()
        {
            //Arrange
            var cola = new CafeMenuItem() { Name = "Cola", Price = 0.50 };
            var coffee = new CafeMenuItem() { Name = "Coffee", Price = 1.00 };
            var cheeseSandwich = new CafeMenuItem() { Name = "Cheese Sandwich", Price = 2.00, IsHot = true };
            var expectedValue = 0.35;

            //Act
            var result = (cola.Price + coffee.Price + cheeseSandwich.Price) * 0.10;

            //Assert
            Assert.AreNotEqual(expectedValue, result);
        }

        [TestMethod]
        public void CalculateServiceCharge_ColdFood_False()
        {
            //Arrange
            var cola = new CafeMenuItem() { Name = "Cola", Price = 0.50 };
            var coffee = new CafeMenuItem() { Name = "Coffee", Price = 1.00 };
            var cheeseSandwich = new CafeMenuItem() { Name = "Cheese Sandwich", Price = 2.00, IsHot = true };
            var expectedValue = 0.85;

            //Act
            var result = (cola.Price + coffee.Price + cheeseSandwich.Price) * 0.10;

            //Assert
            Assert.AreNotEqual(expectedValue, result);
        }
    }
}
