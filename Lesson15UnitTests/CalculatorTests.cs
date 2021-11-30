using Lektion15Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lesson15UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator calculator;

        [ClassInitialize]
        public static void ClassSetup(TestContext testContext)
        {
            
        }

        [ClassCleanup]
        public static void ClassTeardown()
        {

        }

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
            //Opened file.
        }

        [TestCleanup]
        public void Teardown()
        {
            //Close file.
        }

        [TestMethod, TestCategory("Adding")]
        public void Should_Get5_When_Adding2And3()
        {
            // Arrange / Given
            int expected = 5;

            // Act / When
            int actual = calculator.Add(2, 3);

            // Assert / Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, TestCategory("Adding")]
        public void Should_Get3_When_Adding2And1()
        {
            // Arrange / Given
            int expected = 3;

            // Act / When
            int actual = calculator.Add(2, 1);

            // Assert / Then
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod, TestCategory("Adding")]
        [DataRow(2, 2, 4, "Hello")]
        [DataRow(2, -2, 0, "Hello2")]
        [DataRow(2, 4, 6, "Hello3")]
        [DataRow(22, 2, 24, "Hello4")]
        [DataRow(20, -2, 18, "Hello5")]
        [DataRow(0, 20, 20, "Hello6")]
        //[DataSource("file.txt")]

        public void Should_GetRightResult_When_Adding(int number1, int number2, int expected, string message)
        {
            // Arrange / Given

            // Act / When
            int actual = calculator.Add(number1, number2);

            // Assert / Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, TestCategory("AmountOfCalculations")]
        public void Should_Get3_When_CheckingAmountOfCalculationsAfterThreeCalculations()
        {
            // Arrange / Given
            int expected = 3;

            // Act / When
            calculator.Add(2, 1);
            calculator.Add(2, 1);
            calculator.Add(2, 1);
            int actual = calculator.amountOfCalculations;

            // Assert / Then
            Assert.AreEqual(expected, actual);
        }
    }
}
