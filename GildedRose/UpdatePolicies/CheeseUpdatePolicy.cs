using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.UpdatePolicies
{
    /// <summary>
    /// Represents the update policy for cheeses.
    /// </summary>
    class CheeseUpdatePolicy : IUpdatePolicy
    {
        /// <summary>
        /// Updates the sell in and quality of the specified item.
        /// </summary>
        /// <param name="item">The item to update.</param>
        public void UpdateItem(Item item)
        {
            // Aged brie increases in quality the older it gets.
            item.Quality++;
            item.SellIn--;
        }
    }
}
