namespace Calculator.Tests;

public class Add
{
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(0, 2, 2)]
    [InlineData(2, 20, 22)]
    public void AddsAllEntriesCorrectly(int a, int b, int expected)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
