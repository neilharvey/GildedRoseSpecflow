using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Updates
{
    class BackstagePassUpdateStrategy :UpdateStrategy
    {
        protected override int GetUpdatedQuality(Item item)
        {
            if (item.SellIn > 10)
            {
                return item.Quality + 1;
            }
            else if (item.SellIn > 5)
            {
                return item.Quality + 2;
            }
            else if (item.SellIn > 0)
            {
                return item.Quality + 3;
            }
            else
            {
                return 0;
            }
        }

        protected override int GetUpdatedSellIn(Item item)
        {
            return item.SellIn - 1;
        }
    }
}
