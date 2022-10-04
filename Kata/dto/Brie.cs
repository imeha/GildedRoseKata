namespace Kata.dto;

public class Brie : Item
{
  public Brie(string name, int sellIn, int quality) : base(name, sellIn, quality)
  {
  }

  public override void GettingAged()
  {
    SellIn--;
    IncreaseQuality(SellIn > 0 ? 1 : 50);
  }
}
