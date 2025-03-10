namespace PrincipeO;

public class Rectangle : Shape
{
  public int Height { get; set; }
  public int Width { get; set; }

  public override int Surface => Height * Width;
}
