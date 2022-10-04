namespace Kata;

public class Item
{
  public string Name { get; set; }
  public int SellIn { get; set; }
  public int Quality { get; set; }

  public Item(string name, int sellIn, int quality)
  {
    Name = name;
    SellIn = sellIn;
    Quality = quality;
  }

  public override string ToString()
  {
    return Name + ", " + SellIn + ", " + Quality;
  }

  public virtual void GettingAged() {}

  protected void IncreaseQuality(int factor)
  {
    if (Quality + factor <= 50) Quality += factor;
    else Quality = 50;
  }

  protected void DecreaseQuality(int factor)
  {
    if (Quality - factor > 0) Quality -= factor;
    else Quality = 0;
  }
}
