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

        [Given(@"an item with quality of (\d+)")]
        public void GivenAnItemWithQualityOf(int quality)
        {
            _program = new Program()
            {
                Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = quality } }
            };
        }

        [When(@"the system updates the inventory")]
        public void WhenTheSystemUpdatesTheInventory()
        {
            _program.UpdateQuality();
        }

        [Then(@"the item should have a quality of (\d+)")]
        public void ThenTheItemShouldHaveAQualityOf(int quality)
        {
            Assert.AreEqual(quality, _program.Items[0].Quality);
        }

        [Given(@"an item with a sell in of (\d+)")]
        public void GivenAnItemWithASellInOf(int sellin)
        {
            _program = new Program()
            {
                Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = sellin, Quality = 5 } }
            };
        }

        [Then(@"the item should have a sell in of (\d+)")]
        public void ThenTheItemShouldHaveASellInOf(int sellIn)
        {
            Assert.AreEqual(sellIn, _program.Items[0].SellIn);
        }

        [Given(@"an item with a sell in of (\d+) and a quality of (\d+)")]
        public void GivenAnItemWithASellInOfAndAQualityOf(int sellIn, int quality)
        {
            _program = new Program()
            {
                Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = sellIn, Quality = quality } }
            };
        }

        [Given(@"an item with the name ""(.*)"" and a quality of (\d+)")]
        public void GivenAnItemWithTheNameAndAQualityOf(string name, int quality)
        {
            _program = new Program()
            {
                Items = new List<Item> { new Item { Name = name, SellIn = 10, Quality = quality } }
            };
        }

        [Given(@"an item with the name ""(.*)"" and a sell in of (\d+)")]
        public void GivenAnItemWithTheNameAndASellInOf(string name, int sellIn)
        {
            _program = new Program()
            {
                Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = 10 } }
            };
        }

        [Given(@"an item with the name ""(.*)"", a quality of (\d+) and a sell in of (\d+)")]
        public void GivenAnItemWithTheNameAQualityAndASellInOf(string name, int quality, int sellIn)
        {
            _program = new Program()
            {
                Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } }
            };            
        }
    }
}
