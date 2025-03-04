namespace TPCalculator.Operations;

public class Modulo : Operation
{
  public Modulo(int opLeft, int opRight) : base(opLeft, opRight) { }

  public override void Execute()
  {
    Result = OperandLeft % OperandRight;
  }

  public override string ToString()
  {
    return $"{OperandLeft} % {OperandRight} = {Result}";
  }
}
