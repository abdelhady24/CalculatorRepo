using CalculatorLogic;
using System;
using Xunit;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            var x = new Calculator().Sum(1, 2);
            Assert.Equal(3, x);
        }

        [Fact]
        public void ShouldMultiplyTwoNumbers()
        {
            var x = new Calculator().Multiply(3, 2);
            Assert.Equal(6, x);
        }
        [Fact]
        public void ShouldDivideTwoNumbers()
        {
            var x = new Calculator().Divide(10, 2);
            Assert.Equal(5, x);
        }

        [Fact]
        public void DivideByZero()
        {
            var x = new Calculator().Divide(10, 0);
            Assert.Equal(-999, x);
        }
        [Fact]
        public void ShouldSubtractTwoNumbers()
        {
            var x = new Calculator().Subtract(2, 1);
            Assert.Equal(1, x);
        }
        // Write a unit test for getting valid operation
        // Write a unit test for getting valid color option
        // Write a unit test for getting valid operation
        // To increase the code coverage
        // Make every step in Main a funtion in Console Project to make test it and cover all code in Console Project
    }
}
