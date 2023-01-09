using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Shop;

public class QualityManager
{
    public QualityManager(IList<Item> items)
    {
        
    }

    public void UpdateQuality(Item item)
    {
        if (item.Quality > 0)
        {
            if (item.Name.IndexOf("Backstage passes") >= 0)
            {
                if (item.SellIn > 0 && item.SellIn <= 5)
                {
                    item.Quality += 3;
                }
                else if (item.SellIn <= 10)
                {
                    item.Quality += 2;
                }
                else if (item.SellIn > 10)
                    item.Quality++;
                else
                    item.Quality = 0;
            }
            else
            {
                switch (item.Name)
                {
                    case "Camembert":
                        item.Quality++;
                        break;
                    case "Ricotta":
                        item.Quality -= 2;
                        break;
                    case "Pokemon card rare collection":
                        break;

                    default:
                        item.Quality--;
                        break;

                }
            }

        }
    }
}