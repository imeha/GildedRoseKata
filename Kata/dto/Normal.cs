namespace Kata.dto;

public class Normal : Item
{
  public Normal(string name, int sellIn, int quality) : base(name, sellIn, quality)
  {
  }

  public override void GettingAged()
  {
    SellIn--;
    DecreaseQuality(SellIn < 0 ? 2 : 1);
  }
}
