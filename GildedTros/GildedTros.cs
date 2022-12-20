using System.Collections.Generic;

namespace GildedTros
{
    public class GildedTros
    {
        private readonly IList<Item> _items;
        private readonly IList<string> SmellyItemNames;
        public GildedTros(IList<Item> items)
        {
            _items = items;
            SmellyItemNames = new List<string>() { "Duplicate Code", "Long Methods", "Ugly Variable Names" };
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
                    case var s when SmellyItemNames.Contains(item.Name):
                        UpdateSmellyItemQuality(item);
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

        private static void UpdateSmellyItemQuality(Item item)
        {
            item.Quality -= 2;
            if (item.SellIn < 0)
            {
                item.Quality -= 2;
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