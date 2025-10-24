namespace Calculator.UnitTests;

public class CalculatorTests
{
    [Theory]
    [InlineData(3, 5, 8)]
    [InlineData(7, 1, 8)]
    [InlineData(5, 5, 10)]
    public void Sum_ShouldReturnSum_WhenGivenTwoIntegers(int a, int b, int result)
    {
        var sum = Calculator.Sum(a, b);

        Assert.Equal(result, sum);
    }

    [Theory]
    [InlineData(5, 7, -2)]
    [InlineData(4, 2, 2)]
    [InlineData(10, 8, 2)]
    public void Min_ShouldReturnValidResult_WhenGivenTwoIntegers(int a, int b, int result)
    {
        var min = Calculator.Min(a, b);

        Assert.Equal(result, min);
    }

    [Theory]
    [InlineData(5, 5, 25)]
    [InlineData(10, 10, 100)]
    [InlineData(6, 3, 18)]
    public void Multiply_ShouldGiveMultiplication_WhenGivenTwoIntegers(int a, int b, int result)
    {
        var multiply = Calculator.Multiply(a, b);

        Assert.Equal(result, multiply);
    }
}