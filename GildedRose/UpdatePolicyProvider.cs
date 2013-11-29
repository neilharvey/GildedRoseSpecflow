using System;
using GildedRose.UpdatePolicies;

namespace GildedRose
{
    /// <summary>
    /// Provides an IUpdatePolicy instance which can be used to update the state of an item.
    /// </summary>
    public class UpdatePolicyProvider
    {
        /// <summary>
        /// Returns the update policy to use for the specified inventory item.
        /// </summary>
        /// <param name="item">The item to update.</param>
        /// <returns>An IUpdatePolicy instance which can be used to update the item.</returns>
        public IUpdatePolicy GetUpdatePolicy(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return new CheeseUpdatePolicy();
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryUpdatePolicy();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePassUpdatePolicy();
                default:
                    return new StandardUpdatePolicy();
            }
        }
    }
}
