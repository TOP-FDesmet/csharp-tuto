using TPCalculator.Operations;

namespace TPCalculator;

public class Calculator
{
  public Operation Operation { get; }
  public int Result => Operation.Result;

  public Calculator(Operation operation)
  {
    Operation = operation;
  }

  public void Execute()
  {
    if (Operation is Addition addition)
    {
      addition.Execute();
    }
    else if (Operation is Substraction substraction)
    {
      substraction.Execute();
    }
    else if (Operation is Multiplication multiplication)
    {
      multiplication.Execute();
    }
    else if (Operation is Division division)
    {
      division.Execute();
    }
    else if (Operation is Modulo modulo)
    {
      modulo.Execute();
    }
    else
    {
      Console.WriteLine("Opération non reconnue !");
    }
  }
}
