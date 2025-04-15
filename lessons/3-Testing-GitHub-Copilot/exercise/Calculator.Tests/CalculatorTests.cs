using Xunit;
using System;

namespace Calculator.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new Calculator();

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        Assert.Equal(5, _calculator.Add(2, 3));
        Assert.Equal(-1, _calculator.Add(2, -3));
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        Assert.Equal(-1, _calculator.Subtract(2, 3));
        Assert.Equal(5, _calculator.Subtract(2, -3));
    }

    [Fact]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        Assert.Equal(6, _calculator.Multiply(2, 3));
        Assert.Equal(-6, _calculator.Multiply(2, -3));
    }

    [Fact]
    public void Modulus_ShouldReturnCorrectRemainder()
    {
        Assert.Equal(1, _calculator.Modulus(10, 3));
    }

    [Fact]
    public void Modulus_ShouldThrowDivideByZeroException_WhenDivisorIsZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Modulus(10, 0));
    }

    [Fact]
    public void SquareRoot_ShouldReturnCorrectResult()
    {
        Assert.Equal(4, _calculator.SquareRoot(16));
    }

    [Fact]
    public void SquareRoot_ShouldThrowArgumentException_WhenInputIsNegative()
    {
        Assert.Throws<ArgumentException>(() => _calculator.SquareRoot(-4));
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(17, true)]
    [InlineData(18, false)]
    [InlineData(1, false)]
    [InlineData(0, false)]
    [InlineData(-5, false)]
    public void IsPrime_ShouldReturnCorrectResult(int number, bool expected)
    {
        Assert.Equal(expected, _calculator.IsPrime(number));
    }

    [Fact]
    public void Power_ShouldReturnCorrectResult()
    {
        Assert.Equal(8, _calculator.Power(2, 3));
        Assert.Equal(0.25, _calculator.Power(2, -2));
        Assert.Equal(1, _calculator.Power(5, 0));
    }
}