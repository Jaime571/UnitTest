using System;
using Xunit;
using CalculatorLib;

namespace CalculatorUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdd3And3() //2 Números negativos
        {
            // Arrange
            double a = -2;
            double b = -3;
            double expected = -5;
            // Act
            var calc = new Calculator();
            double actual = calc.Add(a, b);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdd4And3() //2 números con diferete signo
        {
            // Arrange
            double a = -7;
            double b = 9;
            double expected = 2;
            // Act
            var calc = new Calculator();
            double actual = calc.Add(a, b);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdd5And3() //Decimales
        {
            // Arrange
            double a = 526.98;
            double b = 89.65;
            double expected = 616.63;
            // Act
            var calc = new Calculator();
            double actual = calc.Add(a, b);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdd6sAnd3() //Decimales y negarivos
        {
            // Arrange
            double a = 526.98;
            double b = - 89.65;
            double expected = 437.33;
            // Act
            var calc = new Calculator();
            double actual = calc.Add(a, b);
            // Assert
            Assert.Equal(expected, actual);
        }


    }
}
