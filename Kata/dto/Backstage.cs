namespace Kata.dto;

public class Backstage : Item
{
  public Backstage(string name, int sellIn, int quality) : base(name, sellIn, quality)
  {
  }

  public override void GettingAged()
  {
    SellIn--;
    switch (SellIn)
    {
      case < 0:
        DecreaseQuality(50);
        break;
      case < 6:
        IncreaseQuality(3);
        break;
      case < 11:
        IncreaseQuality(2);
        break;
      default:
        DecreaseQuality(1);
        break;
    }
  }
}
