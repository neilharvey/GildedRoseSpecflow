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
        [Given("an item with quality of (.*)")]
        public void AnItemWithQualityOf(int quality)
        {
            ScenarioContext.Current.Pending();
        }

        [When("the system updates the inventory")]
        public void WhenTheSystemUpdatesTheInventory()
        {
            ScenarioContext.Current.Pending();
        }

        [Then("the item should have a quality of (.*)")]
        public void ThenTheItemShouldHaveAQualityOf(int quality)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
