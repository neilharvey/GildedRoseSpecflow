using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Updates
{
    public abstract class UpdateStrategy
    {
        protected abstract int GetUpdatedQuality(Item item);
        protected abstract int GetUpdatedSellIn(Item item);

        public void UpdateItem(Item item)
        {
            item.Quality = GetUpdatedQuality(item);
            item.SellIn = GetUpdatedSellIn(item);
            // TODO : Constraints
        }
    }
}
