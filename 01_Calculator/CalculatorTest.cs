using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(4, Calculator.Add(2, 2));
            Assert.AreEqual(8, Calculator.Add(2, 6));
        }

        [TestMethod]
        public void AddString()
        {
            Assert.AreEqual(5, Calculator.AddString("3", "2"));
            Assert.AreEqual(7, Calculator.AddString("1", "6"));
        }

        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }
        [TestMethod]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[2];
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

        }
        [TestMethod]
        public void Multiply()
        {
            Assert.AreEqual(4, Calculator.Multiply(2, 2));
            Assert.AreEqual(8, Calculator.Multiply(2, 4));
        }
        [TestMethod]
        public void Power()
        {
            Assert.AreEqual(4, Calculator.Power(2, 2));
            Assert.AreEqual(9, Calculator.Power(3, 2));
        }
        [TestMethod]
        public void Factorial()
        {
            Assert.AreEqual(1, Calculator.Factorial(0));
            Assert.AreEqual(1, Calculator.Factorial(1));
            Assert.AreEqual(2, Calculator.Factorial(2));
            Assert.AreEqual(120, Calculator.Factorial(5));
            Assert.AreEqual(3628800, Calculator.Factorial(10));

            //# http://en.wikipedia.org/wiki/Factorial
            //  it "computes the factorial of 0"
            //  it "computes the factorial of 1"
            //  it "computes the factorial of 2"
            //  it "computes the factorial of 5"
            //  it "computes the factorial of 10"
        }
    }
}
