
/*
 * File: GildedRoseItemTest.cs
 * ----------------------------
 * This file contains unit tests for GildedRose item.
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GildedRose;

namespace GildedRoseTest
{
    [TestClass]
    public class GildedRoseItemTest
    {
        private Item inputItem;
        private Item outputItem;

        [TestMethod]
        public void TestCreateGRItem()
        {
            InitInputItem("Aged Brie", 20, 10);
            CreateOutputItem();
            RunAsserts();
        }

        private void InitInputItem(string Name, int Quality, int SellIn)
        {
            inputItem = new Item()
            {
                Name = Name,
                Quality = Quality,
                SellIn = SellIn
            };
        }

        private void CreateOutputItem()
        {
            GildedRoseItem<Item> gildedRoseInventoryItem = new GildedRoseItemImpl(inputItem);
            outputItem = gildedRoseInventoryItem.Value;
        }

        private void RunAsserts()
        {
            Assert.AreNotSame(outputItem, inputItem);
            Assert.AreEqual(outputItem.Name, inputItem.Name);
            Assert.AreEqual(outputItem.Quality, inputItem.Quality);
            Assert.AreEqual(outputItem.SellIn, inputItem.SellIn);
        }
    }
}
