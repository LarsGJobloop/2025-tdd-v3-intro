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

    [Theory]
    [InlineData(int.MaxValue, 1)]
    [InlineData(1, int.MaxValue)]
    public void AddingMaxShouldShouldThrow(int a, int b)
    {
        // Arrange
        var calculator = new Calculator();

        // Act & Assert
        Assert.Throws<Exception>(() => calculator.Add(a, b));
    }
}
