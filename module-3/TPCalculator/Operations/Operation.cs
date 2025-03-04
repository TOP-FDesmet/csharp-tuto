namespace TPCalculator.Operations;

public abstract class Operation
{
  protected int OperandLeft { get; }
  protected int OperandRight { get; }
  public int Result { get; protected set; }

  protected Operation(int opLeft, int opRight)
  {
    OperandLeft = opLeft;
    OperandRight = opRight;
  }

  public abstract void Execute();
}
