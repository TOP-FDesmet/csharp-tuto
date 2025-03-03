namespace TPCalculator.Operations;

public class Substraction : Operation
{
  public Substraction(int opLeft, int opRight) : base(opLeft, opRight)
  {

  }

  public void Execute()
  {
    Result = OperandLeft - OperandRight;
  }
}
