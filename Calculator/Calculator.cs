namespace Calculator;

public class Calculator
{
  public int Add(int a, int b)
  {
    if (a == int.MaxValue || b == int.MaxValue)
    {
      throw new Exception($"Argument to large, got: {a}");
    }
    return a + b;
  }
}
