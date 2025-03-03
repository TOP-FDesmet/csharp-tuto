namespace TPCalculator;

public class Calculator
{
  public int OperandLeft { get; set; }
  public int OperandRight { get; set; }
  public int Result { get; set; }

  public void Addition()
  {
    Result = OperandLeft + OperandRight;
  }

  public void Substraction()
  {
    Result = OperandLeft - OperandRight;
  }

  public void Multiplication()
  {
    Result = OperandLeft * OperandRight;
  }

  public void Division()
  {
    if (OperandRight == 0)
    {
      Result = 0;
    }
    Result = OperandLeft / OperandRight;
  }

  public void Modulo()
  {
    Result = OperandLeft % OperandRight;
  }
}
