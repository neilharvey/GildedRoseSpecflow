using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.UpdatePolicies
{
    /// <summary>
    /// Represents the update policy for conjured items.
    /// </summary>
    class ConjuredUpdatePolicy : IUpdatePolicy
    {
        /// <summary>
        /// Updates the sell in and quality of the specified item.
        /// </summary>
        /// <param name="item">The item to update.</param>
        public void UpdateItem(Item item)
        {
            item.SellIn--;
            item.Quality -= 2;
        }
    }
}
