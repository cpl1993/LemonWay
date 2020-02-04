using System;
using LemonWayBusiness;
using LemonWayBusiness.CustomException;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonWayBusiness.Tests
{
    [TestClass]
    public class MathematicTest
    {
        [TestMethod]
        public void If_Parameter_Between_1_And_100_Then_Return_Fibonnaci_Result()
        {
            // Arrange
            int number = 8;

            // Act
            int fibonnaciResult = Mathematic.Fibonnaci(number);

            // Assert
            Assert.AreEqual(fibonnaciResult, 21);
        }

        [TestMethod]
        public void If_Parameter_Is_Less_1_Then_Return_Less_1()
        {
            // Arrange
            int negativeNumber = -5;

            // Act
            int fibonnaciResult = Mathematic.Fibonnaci(negativeNumber);

            // Assert
            Assert.AreEqual(fibonnaciResult, -1);
        }

        [TestMethod]
        public void If_Parameter_Is_More_Than_100_Then_Return_Less_1()
        {
            // Arrange
            int numberMoreThan100 = 101;

            // Act
            int fibonnaciResult = Mathematic.Fibonnaci(numberMoreThan100);
            
            // Assert
            Assert.AreEqual(fibonnaciResult, -1);
        }
    }
}
