using Kata;

public class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("OMGHAI!");
    var watch = new System.Diagnostics.Stopwatch();


    IList<Item> items = new List<Item>{
      new Item(name: "+5 Dexterity Vest", sellIn: 10, quality: 20),
      new Item(name: "Aged Brie", sellIn: 2, quality: 0),
      new Item(name: "Elixir of the Mongoose", sellIn: 5, quality: 7),
      new Item(name: "Sulfuras, Hand of Ragnaros", sellIn: 0, quality: 80),
      new Item(name: "Sulfuras, Hand of Ragnaros", sellIn: -1, quality: 80),
      new Item(name: "Backstage passes to a TAFKAL80ETC concert", sellIn: 15, quality: 20),
      new Item(name: "Backstage passes to a TAFKAL80ETC concert", sellIn: 10, quality: 49),
      new Item(name: "Backstage passes to a TAFKAL80ETC concert", sellIn: 5, quality: 49),
      new Item(name: "Conjured Mana Cake", sellIn: 3, quality: 6)
    };

    var appRefactored = new GildedRoseRefactored(items);

    Console.WriteLine("refactored app");
    watch.Start();
    for (var i = 0; i < 32; i++)
    {
      Console.WriteLine("-------- day " + i + " --------");
      Console.WriteLine("name, sellIn, quality");
      for (var j = 0; j < items.Count; j++)
      {
        System.Console.WriteLine(appRefactored.items[j]);
      }
      Console.WriteLine("");
      appRefactored.UpdateQuality();
    }
    watch.Stop();

    Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
  }
}
