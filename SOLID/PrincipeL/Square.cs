using PrincipeL;

namespace PrincipeO;

public class Square : ShapeWithSurface
{
  public int SideSize { get; set; }

  public override int Surface => SideSize * SideSize;
}
