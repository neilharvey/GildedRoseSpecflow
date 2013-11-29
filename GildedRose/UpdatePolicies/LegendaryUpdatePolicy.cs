using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.UpdatePolicies
{
    /// <summary>
    /// Represents the update policy for legendary items.
    /// </summary>
    class LegendaryUpdatePolicy : IUpdatePolicy
    {
        /// <summary>
        /// Updates the sell in and quality of the specified item.
        /// </summary>
        /// <param name="item">The item to update.</param>
        public void UpdateItem(Item item)
        {
            // Legendary items never decrease in quality and never need to be sold.
        }
    }
}
