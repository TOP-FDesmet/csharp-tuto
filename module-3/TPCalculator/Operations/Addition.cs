namespace TPCalculator.Operations;

public class Addition : Operation
{
  public Addition(int opLeft, int opRight) : base(opLeft, opRight) { }

  public override void Execute()
  {
    Result = OperandLeft + OperandRight;
  }

  public override string ToString()
  {
    return $"{OperandLeft} + {OperandRight} = {Result}";
  }
}
