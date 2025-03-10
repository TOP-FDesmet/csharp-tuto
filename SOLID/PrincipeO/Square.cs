namespace PrincipeO;

public class Square : Shape
{
  public int SideSize { get; set; }

  public override int Surface => SideSize * SideSize;
}
