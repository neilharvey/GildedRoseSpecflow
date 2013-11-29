using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Updates
{
    class StandardUpdateStrategy : UpdateStrategy
    {
        protected override int GetUpdatedQuality(Item item)
        {
            return item.Quality - 1;
        }

        protected override int GetUpdatedSellIn(Item item)
        {
            return item.SellIn - 1;
        }
    }
}
