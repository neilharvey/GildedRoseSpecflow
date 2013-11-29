using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Updates
{
    public class AgedBrieUpdateStrategy : UpdateStrategy
    {

        public int GetUpdatedQuality(Item item)
        {
            return item.Quality + 1;
        }

        public int GetUpdatedSellIn(Item item)
        {
            return item.SellIn - 1;
        }
    }
}
