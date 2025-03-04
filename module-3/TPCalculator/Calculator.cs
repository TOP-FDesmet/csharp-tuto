using TPCalculator.Interfaces;

namespace TPCalculator;

public class Calculator
{
  private IOperation Operation { get; }
  public int Result => Operation.Result;

  public Calculator(IOperation operation)
  {
    History.Operations.Add(operation);
    Operation = operation;
  }

  public void Execute()
  {
    Operation.Execute();
  }
}
