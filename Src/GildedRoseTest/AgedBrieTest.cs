
/*
 * File: AgedBrieTest.cs
 * ------------------------
 * This file contains the unit tests for an Aged Brie.
 */

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRose;

namespace GildedRoseTest
{
    [TestClass]
    public class AgedBrieTest
    {
        
        [TestMethod]
        public void AgedBrieTestQualityOneUpdate()
        {
            Item inputItem = new Item()
            {
                Name = "Aged Brie",
                Quality = 10,
                SellIn = 15
            };

            Item outputItem = new Item()
            {
                Name = inputItem.Name,
                Quality = inputItem.Quality + 1,
                SellIn = inputItem.SellIn - 1
            };

            UpdateQualityForItem(inputItem);

            Assert.AreEqual(outputItem.Name, inputItem.Name);
            Assert.AreEqual(outputItem.Quality, inputItem.Quality);
            Assert.AreEqual(outputItem.SellIn, inputItem.SellIn);
        }

        [TestMethod]
        public void AgedBrieTestQualityTwoUpdate()
        {
            Item inputItem = new Item()
            {
                Name = "Aged Brie",
                Quality = 10,
                SellIn = 10
            };

            Item outputItem = new Item()
            {
                Name = inputItem.Name,
                Quality = inputItem.Quality + 2,
                SellIn = inputItem.SellIn - 1
            };

            UpdateQualityForItem(inputItem);

            Assert.AreEqual(outputItem.Name, inputItem.Name);
            Assert.AreEqual(outputItem.Quality, inputItem.Quality);
            Assert.AreEqual(outputItem.SellIn, inputItem.SellIn);
        }

        private void UpdateQualityForItem(Item inputItem)
        {
            IList<Item> itemList = new List<Item>();
            itemList.Add(inputItem);

            GildedRose.GildedRose gildedRose = new GildedRose.GildedRose(itemList);
            gildedRose.UpdateQuality();
        }

    }
}
