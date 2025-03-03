namespace TPCalculator;

public class Calculator
{
  public int OperandLeft { get; }
  public int OperandRight { get; }
  public int Result { get; set; }

  public Calculator(int opLeft, int opRight)
  {
    OperandLeft = opLeft;
    OperandRight = opRight;
  }

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
