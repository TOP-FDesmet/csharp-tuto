namespace TPCalculator.Operations;

public class Puissance : Operation
{
  public Puissance(int opLeft, int opRight) : base(opLeft, opRight) { }

  public override void Execute()
  {
    Result = (int)Math.Pow(OperandLeft, OperandRight);
  }

  public override string ToString()
  {
    return $"{OperandLeft} ^ {OperandRight} = {Result}";
  }
}
