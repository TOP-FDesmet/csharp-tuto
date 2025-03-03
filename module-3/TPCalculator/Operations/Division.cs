namespace TPCalculator.Operations;

public class Division : Operation
{
  public Division(int opLeft, int opRight) : base(opLeft, opRight)
  {

  }

  public void Execute()
  {
    if (OperandRight != 0)
    {
      Result = OperandLeft / OperandRight;
    }
  }
}
