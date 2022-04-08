using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


public class CalculatorTests
{
    [Fact]
    public void MultiplicationShouldReturnNotNullValue()
    {
        var calc = new Calculator();
        //   calc.Multiplication(2, 4); = 8

        Assert.Equal(8, calc.Multiplication(2, 4));
    }

    [Fact]
    public void SubstractionShloudReturnNotNullValue()
    {
        var calc = new Calculator();
        Assert.Equal(4, calc.Subtraction(8, 4));
    }

    [Fact]
    public void DivisionShouldReturnNotNullValue()
    {
        var calc = new Calculator();
        Assert.Equal(10, calc.Division(40, 4));
    }

    [Fact]
    public void DivisionShouldReturnExceptionWhitchDivisionNull()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Division(30, 0));
    }
}

