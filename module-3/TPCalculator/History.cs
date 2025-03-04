using TPCalculator.Interfaces;

namespace TPCalculator;

public static class History
{
  public static List<IOperation> Operations { get; }
    = [];
}
