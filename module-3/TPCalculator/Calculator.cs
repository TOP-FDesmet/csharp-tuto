using TPCalculator.Operations;

namespace TPCalculator;

public class Calculator
{
  public Operation Operation { get; }
  public int Result => Operation.Result;

  public Calculator(Operation operation)
  {
    Operation = operation;
  }

  public void Execute()
  {
    Operation.Execute();
  }
}
