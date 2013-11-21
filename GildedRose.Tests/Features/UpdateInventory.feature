Feature: Update Inventory
	As an inn keeper
	I want the system to automatically update item quality and sell by dates
	So that I can keep track of items

Scenario: Quality reduces each day
	Given an item with quality of 10
	When the system updates the inventory
	Then the item should have a quality of 9

Scenario: Sell by date reduces each day
	Given an item with a sell in of 10
	When the system updates the inventory
	Then the item should have a sell in of 9