namespace TPCalculator.Operations;

public class Substraction : Operation
{
  public Substraction(int opLeft, int opRight) : base(opLeft, opRight) { }

  public override void Execute()
  {
    Result = OperandLeft - OperandRight;
  }

  public override string ToString()
  {
    return $"{OperandLeft} - {OperandRight} = {Result}";
  }
}
