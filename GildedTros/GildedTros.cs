using GildedTros.App;
using System.Collections.Generic;

namespace GildedTros
{
    public class GildedTros
    {
        private readonly IList<Item> _items;
        public GildedTros(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                if (item.Name == "B-DAWG Keychain") continue;

                item.SellIn--;

                switch (item.Name)
                {
                    case "Good Wine":
                        UpdateWineQuality(item);
                        break;
                    case var s when item.Name.Contains("Backstage passes"):
                        UpdateBackstagePassesQuality(item);
                        break;
                    default:
                        UpdateNormalItemQuality(item);
                        break;
                }

                NormalizeQuality(item);
            }
        }

        private static void UpdateNormalItemQuality(Item item)
        {
            item.Quality--;
            if (item.SellIn < 0)
            {
                item.Quality--;
            }
        }

        private static void UpdateWineQuality(Item item)
        {
            item.Quality++;

            if (item.SellIn < 0)
            {
                item.Quality++;
            }
        }

        private static void UpdateBackstagePassesQuality(Item item)
        {
            switch (item.SellIn)
            {
                case < 0:
                    item.Quality = 0;
                    break;
                case < 5:
                    item.Quality += 3;
                    break;
                case < 10:
                    item.Quality += 2;
                    break;
                default:
                    item.Quality++;
                    break;
            }
        }

        private static void NormalizeQuality(Item item)
        {
            if (item.Quality > 50)
            {
                item.Quality = 50;
            }
            else if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}