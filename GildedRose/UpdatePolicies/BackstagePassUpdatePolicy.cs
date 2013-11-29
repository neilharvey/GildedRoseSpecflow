using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.UpdatePolicies
{
    /// <summary>
    /// Represents the update policy for backstage passes.
    /// </summary>
    class BackstagePassUpdatePolicy : IUpdatePolicy
    {
        /// <summary>
        /// Updates the sell in and quality of the specified item.
        /// </summary>
        /// <param name="item">The item to update.</param>
        public void UpdateItem(Item item)
        {
            item.SellIn--;

            // "Backstage passes", like aged brie, increases in Quality as it's SellIn value approaches
            if (item.SellIn > 10)
            {
                item.Quality++;
            }

            // Quality increases by 2 when there are 10 days or less..
            if (item.SellIn <= 10)
            {
                item.Quality += 2;
            }

            // .. and by 3 when there are 5 days or less
            if (item.SellIn <= 5)
            {
                item.Quality++;
            }

            // .. but Quality drops to 0 after the concert
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
