using System.Collections.Generic;
using Xunit;

namespace GildedTros
{
    public class GildedTrosTest
    {
        [Collection("IntegrationTest")]
        public class When_updating_the_quality_of_a_young_wine
        {
            private readonly Item _item;
            public When_updating_the_quality_of_a_young_wine()
            {
                _item = new Item { Name = "Good Wine", SellIn = 20, Quality = 0 };
                IList<Item> items = new List<Item> { _item };
                var app = new GildedTros(items);
                app.UpdateQuality();
            }
            [Fact]
            public void Then_the_quality_should_be_updated()
            {
                Assert.Equal(19, _item.SellIn);
                Assert.Equal(1, _item.Quality);
            }
        }

        [Collection("IntegrationTest")]
        public class When_updating_the_quality_of_an_old_wine
        {
            private readonly Item _item;
            public When_updating_the_quality_of_an_old_wine()
            {
                _item = new Item { Name = "Good Wine", SellIn = 0, Quality = 0 };
                IList<Item> items = new List<Item> { _item };
                var app = new GildedTros(items);
                app.UpdateQuality();
            }
            [Fact]
            public void Then_the_quality_should_be_updated()
            {
                Assert.Equal(-1, _item.SellIn);
                Assert.Equal(2, _item.Quality);
            }
        }

        [Collection("IntegrationTest")]
        public class When_updating_the_quality_of_a_fine_wine
        {
            private readonly Item _item;
            public When_updating_the_quality_of_a_fine_wine()
            {
                _item = new Item { Name = "Good Wine", SellIn = -25, Quality = 49 };
                IList<Item> items = new List<Item> { _item };
                var app = new GildedTros(items);
                app.UpdateQuality();
            }
            [Fact]
            public void Then_the_quality_should_be_updated()
            {
                Assert.Equal(-26, _item.SellIn);
                Assert.Equal(50, _item.Quality);
            }
        }

        [Collection("IntegrationTest")]
        public class When_updating_the_quality_of_a_legendary_item
        {
            private readonly Item _item;
            public When_updating_the_quality_of_a_legendary_item()
            {
                _item = new Item { Name = "B-DAWG Keychain", SellIn = 0, Quality = 80 };
                IList<Item> items = new List<Item> { _item };
                var app = new GildedTros(items);
                app.UpdateQuality();
            }
            [Fact]
            public void Then_the_quality_should_be_unchanged()
            {
                Assert.Equal(0, _item.SellIn);
                Assert.Equal(80, _item.Quality);
            }
        }

        [Collection("IntegrationTest")]
        public class When_updating_the_quality_of_a_backstage_pass_for_a_conference_in_the_wide_future
        {
            private readonly Item _item;
            public When_updating_the_quality_of_a_backstage_pass_for_a_conference_in_the_wide_future()
            {
                _item = new Item { Name = "Backstage passes for Re:factor", SellIn = 15, Quality = 20 };
                IList<Item> items = new List<Item> { _item };
                var app = new GildedTros(items);
                app.UpdateQuality();
            }
            [Fact]
            public void Then_the_quality_should_be_updated()
            {
                Assert.Equal(14, _item.SellIn);
                Assert.Equal(21, _item.Quality);
            }
        }

        [Collection("IntegrationTest")]
        public class When_updating_the_quality_of_a_backstage_pass_for_a_conference_in_the_near_future
        {
            private readonly Item _item;
            public When_updating_the_quality_of_a_backstage_pass_for_a_conference_in_the_near_future()
            {
                _item = new Item { Name = "Backstage passes for Re:factor", SellIn = 10, Quality = 20 };
                IList<Item> items = new List<Item> { _item };
                var app = new GildedTros(items);
                app.UpdateQuality();
            }
            [Fact]
            public void Then_the_quality_should_be_updated()
            {
                Assert.Equal(9, _item.SellIn);
                Assert.Equal(22, _item.Quality);
            }
        }

        [Collection("IntegrationTest")]
        public class When_updating_the_quality_of_a_backstage_pass_for_an_upcoming_conference
        {
            private readonly Item _item;
            public When_updating_the_quality_of_a_backstage_pass_for_an_upcoming_conference()
            {
                _item = new Item { Name = "Backstage passes for Re:factor", SellIn = 5, Quality = 20 };
                IList<Item> items = new List<Item> { _item };
                var app = new GildedTros(items);
                app.UpdateQuality();
            }
            [Fact]
            public void Then_the_quality_should_be_updated()
            {
                Assert.Equal(4, _item.SellIn);
                Assert.Equal(23, _item.Quality);
            }
        }

        public class When_updating_the_quality_of_a_backstage_pass_for_a_past_conference
        {
            private readonly Item _item;
            public When_updating_the_quality_of_a_backstage_pass_for_a_past_conference()
            {
                _item = new Item { Name = "Backstage passes for Re:factor", SellIn = 0, Quality = 20 };
                IList<Item> items = new List<Item> { _item };
                var app = new GildedTros(items);
                app.UpdateQuality();
            }
            [Fact]
            public void Then_the_quality_should_be_updated()
            {
                Assert.Equal(-1, _item.SellIn);
                Assert.Equal(0, _item.Quality);
            }
        }

        [Collection("IntegrationTest")]
        public class When_updating_the_quality_of_a_regular_item
        {
            private readonly Item _item;
            public When_updating_the_quality_of_a_regular_item()
            {
                _item = new Item { Name = "Bla Bla Item", SellIn = 5, Quality = 20 };
                IList<Item> items = new List<Item> { _item };
                var app = new GildedTros(items);
                app.UpdateQuality();
            }
            [Fact]
            public void Then_the_quality_should_be_updated()
            {
                Assert.Equal(4, _item.SellIn);
                Assert.Equal(19, _item.Quality);
            }
        }

        [Collection("IntegrationTest")]
        public class When_updating_the_quality_of_an_old_regular_item
        {
            private readonly Item _item;
            public When_updating_the_quality_of_an_old_regular_item()
            {
                _item = new Item { Name = "Bla Bla Item", SellIn = 0, Quality = 20 };
                IList<Item> items = new List<Item> { _item };
                var app = new GildedTros(items);
                app.UpdateQuality();
            }
            [Fact]
            public void Then_the_quality_should_be_updated()
            {
                Assert.Equal(-1, _item.SellIn);
                Assert.Equal(18, _item.Quality);
            }
        }

        [Collection("IntegrationTest")]
        public class When_updating_the_quality_of_a_smelly_item
        {
            private readonly Item _item;
            public When_updating_the_quality_of_a_smelly_item()
            {
                _item = new Item { Name = "Duplicate Code", SellIn = 5, Quality = 20 };
                IList<Item> items = new List<Item> { _item };
                var app = new GildedTros(items);
                app.UpdateQuality();
            }
            [Fact]
            public void Then_the_quality_should_be_updated()
            {
                Assert.Equal(4, _item.SellIn);
                Assert.Equal(18, _item.Quality);
            }
        }

        [Collection("IntegrationTest")]
        public class When_updating_the_quality_of_an_old_smelly_item
        {
            private readonly Item _item;
            public When_updating_the_quality_of_an_old_smelly_item()
            {
                _item = new Item { Name = "Duplicate Code", SellIn = 0, Quality = 20 };
                IList<Item> items = new List<Item> { _item };
                var app = new GildedTros(items);
                app.UpdateQuality();
            }
            [Fact]
            public void Then_the_quality_should_be_updated()
            {
                Assert.Equal(-1, _item.SellIn);
                Assert.Equal(16, _item.Quality);
            }
        }
    }
}