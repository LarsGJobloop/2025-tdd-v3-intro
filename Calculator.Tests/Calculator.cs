namespace Calculator.Tests;

public class Add
{
    [Fact]
    public void TwoAndTwoShouldResultInFour()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 2;
        int b = 2;
        int expected = 4;

        // Act
        var result = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void ThreeAndThreeShouldResultInSix()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 3;
        int b = 3;
        int expected = 6;

        // Act
        var result = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
