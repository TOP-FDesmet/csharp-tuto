using PrincipeL;

namespace PrincipeO;

public class SurfaceCalculator
{
  public int ComputeAllSizes(IEnumerable<ShapeWithSurface> shapes)
  {
    int result = 0;
    foreach (var shape in shapes)
    {
      result += shape.Surface;
    }
    return result;
  }

  /* private int ComputeSize(Shape shape)
  {
    return shape switch
    {
      Square s => s.SideSize * s.SideSize,
      Rectangle r => r.Height * r.Width,
      _ => throw new InvalidOperationException()
    };

    if (shape is Square s)
    {
      return s.SideSize * s.SideSize;
    }
    else if (shape is Rectangle r)
    {
      return r.Height * r.Width;
    }
    throw new InvalidOperationException();
  } */
}
