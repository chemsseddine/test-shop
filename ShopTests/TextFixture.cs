using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Shop;

namespace ShopTests
{
    public static class TexttestFixture
    {
        public static void Main()
        {
            Console.WriteLine("Program start !");
            var items = BuildInventory();
            var app = new QualityManager(items);
            int days = 10;
            for (var i = 0; i < days; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < items.Count; j++)
                {
                    Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }

        private static IList<Item> BuildInventory() => 
            JsonConvert.DeserializeObject<IList<Item>>(File.ReadAllText("shop_test_01.json"));
    }
}
