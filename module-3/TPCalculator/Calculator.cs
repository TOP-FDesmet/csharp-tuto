using System;

namespace TPCalculator;

public class Calculator
{
  /// <summary>
  /// This method adds and returns the result
  /// </summary>
  /// <param name="nb1">First number</param>
  /// <param name="nb2">Seconde number</param>
  /// <returns>Add result</returns>
  public int Add(int nb1, int nb2)
  {
    return nb1 + nb2;
  }

  public int Sub(int nb1, int nb2)
  {
    return nb1 - nb2;
  }

  public int Multiplication(int nb1, int nb2)
  {
    return nb1 * nb2;
  }

  public int Division(int nb1, int nb2)
  {
    if (nb2 == 0)
    {
      return 0;
    }
    return nb1 / nb2;
  }

  public int Modulo(int nb1, int nb2)
  {
    return nb1 % nb2;
  }
}
