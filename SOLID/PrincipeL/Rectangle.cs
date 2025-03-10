using PrincipeL;

namespace PrincipeO;

public class Rectangle : ShapeWithSurface
{
  public int Height { get; set; }
  public int Width { get; set; }

  public override int Surface => Height * Width;
}
