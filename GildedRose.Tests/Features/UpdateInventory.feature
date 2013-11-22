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

Scenario: Quality degrades twice as fast once the sell by date has passed 
	Given an item with a sell in of 0 and a quality of 10
	When the system updates the inventory
	Then the item should have a quality of 8

Scenario: Quality of an item is never negative
	Given an item with a sell in of 0 and a quality of 0
	When the system updates the inventory
	Then the item should have a quality of 0

Scenario: Aged Brie increases in quality the older it gets
	Given an item with the name "Aged Brie" and a quality of 10
	When the system updates the inventory
	Then the item should have a quality of 11

Scenario: Quality of an item is never more than 50
	Given an item with the name "Aged Brie" and a quality of 50
	When the system updates the inventory
	Then the item should have a quality of 50

Scenario: Legendary items never decrease in quality
	Given an item with the name "Sulfuras, Hand of Ragnaros" and a quality of 50
	When the system updates the inventory
	Then the item should have a quality of 50

Scenario: Legendary items never need to be sold
	Given an item with the name "Sulfuras, Hand of Ragnaros" and a sell in of 10
	When the system updates the inventory
	Then the item should have a sell in of 10

Scenario: Backstage passes increase in quality slowly when concert date is far away
	Given an item with the name "Backstage passes to a TAFKAL80ETC concert", a quality of 10 and a sell in of 20
	When the system updates the inventory
	Then the item should have a quality of 11

Scenario: Backstage passes increase in quality faster when concert date is near
	Given an item with the name "Backstage passes to a TAFKAL80ETC concert", a quality of 10 and a sell in of 10
	When the system updates the inventory
	Then the item should have a quality of 12

Scenario: Backstage passes increase in quality fastest when concert is very near
	Given an item with the name "Backstage passes to a TAFKAL80ETC concert", a quality of 10 and a sell in of 5
	When the system updates the inventory
	Then the item should have a quality of 13

Scenario: Backstage passes have no value after a concert
	Given an item with the name "Backstage passes to a TAFKAL80ETC concert", a quality of 10 and a sell in of 0
	When the system updates the inventory
	Then the item should have a quality of 0