namespace TPCalculator.Operations;

public abstract class Operation
{
  public int OperandLeft { get; }
  public int OperandRight { get; }
  public int Result { get; set; }

  public Operation(int opLeft, int opRight)
  {
    OperandLeft = opLeft;
    OperandRight = opRight;
  }

  public abstract void Execute();
}
