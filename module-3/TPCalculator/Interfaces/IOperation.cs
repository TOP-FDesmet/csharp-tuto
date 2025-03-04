namespace TPCalculator.Interfaces;

public interface IOperation
{
  void Execute();
  int Result { get; }
}
