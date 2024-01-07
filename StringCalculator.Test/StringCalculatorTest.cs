using System.Runtime.InteropServices;

namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void AddZero()
        {
            var stringCalculator = new StringCalculator();
            var number = stringCalculator.Add("");
            Assert.AreEqual(0, number);
        }

        [TestMethod]
        public void AddOne()
        {
            var stringCalculator = new StringCalculator();
            var number = stringCalculator.Add("9");
            Assert.AreEqual(9, number);
        }

        [TestMethod]
        public void AddTwo()
        {
            var stringCalculator = new StringCalculator();
            var number = stringCalculator.AddTwo("2,4");
            Assert.AreEqual(6, number);
        }

        [TestMethod]
        public void AddMany()
        {
            var stringCalculator = new StringCalculator();
            var number = stringCalculator.AddMany("3,19,12");
            Assert.AreEqual(34, number);
        }

        [TestMethod]
        public void DelimiterTest()
        {
            var stringCalculator = new StringCalculator();
            var number = stringCalculator.AddMany(";\n1\n;2");
            Assert.AreEqual(3, number);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Negatives not allowed: -2")]
        public void NegativeNumberTest()
        {
            // Arrange
            var stringCalculator = new StringCalculator();

            // Act & Assert
            stringCalculator.AddMany(";\n1\n;-2");
        }

        [TestMethod]
        public void NumberOverThousandTest()
        {
            var stringCalculator = new StringCalculator();
            var number = stringCalculator.AddMany("3,19,12,1001");
            Assert.AreEqual(34, number);
        }

        [TestMethod]
        public void CalledCountTest()
        {
            // Arrange
            var stringCalculator = new StringCalculator();

            // Act
            stringCalculator.AddMany("1,2,3");
            stringCalculator.AddMany("4,5");
            int calledCount = stringCalculator.CalledCount;

            // Assert
            Assert.AreEqual(2, calledCount);
        }



    }
}