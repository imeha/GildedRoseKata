namespace Kata.dto;

public class Conjured : Item
{
  public Conjured(string name, int sellIn, int quality) : base(name, sellIn, quality)
  {
  }

  public override void GettingAged()
  {
    SellIn--;
    DecreaseQuality(2);
  }
}
