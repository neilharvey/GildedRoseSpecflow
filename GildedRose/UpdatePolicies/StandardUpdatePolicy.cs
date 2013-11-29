using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.UpdatePolicies
{
    /// <summary>
    /// Represents the standard item update policy.
    /// </summary>
    class StandardUpdatePolicy : IUpdatePolicy
    {
        /// <summary>
        /// Updates the sell in and quality of the specified item.
        /// </summary>
        /// <param name="item">The item to update.</param>
        public void UpdateItem(Item item)
        {
            // At the end of each day our system lowers both values for every item
            item.SellIn--;
            item.Quality--;

            // Once the sell by date has passed, Quality degrades twice as fast
            if (item.SellIn < 0)
            {
                item.Quality--;
            }
        }
    }
}
