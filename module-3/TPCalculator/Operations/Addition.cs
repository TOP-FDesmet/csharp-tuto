namespace TPCalculator.Operations;

public class Addition : Operation
{
  public Addition(int opLeft, int opRight) : base(opLeft, opRight)
  {

  }

  public void Execute()
  {
    Result = OperandLeft + OperandRight;
  }
}
