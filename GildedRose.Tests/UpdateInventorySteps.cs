using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [Binding]
    public class UpdateInventorySteps
    {
        Program _program;

        [Given("an item with quality of (.*)")]
        public void GivenAnItemWithQualityOf(int quality)
        {
            _program = new Program()
            {
                Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = quality } }
            };
        }

        [When("the system updates the inventory")]
        public void WhenTheSystemUpdatesTheInventory()
        {
            _program.UpdateQuality(); 
        }

        [Then("the item should have a quality of (.*)")]
        public void ThenTheItemShouldHaveAQualityOf(int quality)
        {
            Assert.AreEqual(quality, _program.Items[0].Quality);
        }

        [Given("an item with a sell in of (.*)")]
        public void GivenAnItemWithASellInOf(int sellin)
        {
            _program = new Program()
            {
                Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = sellin, Quality = 5 } }
            };
        }

        [Then("the item should have a sell in of (.*)")]
        public void ThenTheItemShouldHaveASellInOf(int sellIn)
        {
            Assert.AreEqual(sellIn, _program.Items[0].SellIn);
        }
    }
}
