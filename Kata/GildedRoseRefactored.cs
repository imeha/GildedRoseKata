using Kata.dto;

namespace Kata;

public class GildedRoseRefactored
{
  public IList<Item> items = new List<Item>();

  public GildedRoseRefactored(IList<Item> items)
  {
    foreach (var item in items)
    {
      this.items?.Add(GetItemType(item));
    }
  }

  public void UpdateQuality()
  {
    foreach (var item in items)
    {
      item.GettingAged();
    }
  }

  private Item  GetItemType(Item item)
  {
    switch (item.Name) {
      case "Aged Brie": return new Brie(item.Name, item.SellIn, item.Quality);
      case "Backstage passes to a TAFKAL80ETC concert": return new Backstage(item.Name, item.SellIn, item.Quality);
      case "Conjured Mana Cake": return new Conjured(item.Name, item.SellIn, item.Quality);
      case "Sulfuras, Hand of Ragnaros": return new Sulfuras(item.Name, item.SellIn, item.Quality);
      default: return new Normal(item.Name, item.SellIn, item.Quality);
    }
  }
}
