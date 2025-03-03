namespace TPCalculator.Operations;

public class Multiplication : Operation
{
  public Multiplication(int opLeft, int opRight) : base(opLeft, opRight)
  {

  }

  public void Execute()
  {
    Result = OperandLeft * OperandRight;
  }
}
