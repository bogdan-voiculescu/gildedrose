
/*
 * File: GildedRoseItemUpdaterTest.cs
 * -----------------------------------
 * This file contains unit tests for GildedRose item updater.
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
    public class GildedRoseItemUpdaterTest
    {
        private Item inputItem;
        private Item outputItem;

        [TestMethod]
        public void TestAgedBrieItemUpdater()
        {
            GildedRoseItemImpl grItem = CreateGRItem("Aged Brie", 25, 20);
            GildedRoseItemUpdater grItemUpdater = new AgedBrieItemUpdater(grItem);
            grItemUpdater.Update();

            inputItem = grItem.Value;

            outputItem = new Item()
            {
                Name = "Aged Brie",
                Quality = 26,
                SellIn = 19
            };

            RunAsserts();
        }

        [TestMethod]
        public void TestBackstageConcertPassItemUpdater()
        {
            GildedRoseItemImpl grItem = CreateGRItem("Backstage passes to a TAFKAL80ETC concert", 25, 20);
            GildedRoseItemUpdater grItemUpdater = new BackstageConcertPassItemUpdater(grItem);
            grItemUpdater.Update();

            inputItem = grItem.Value;

            outputItem = new Item()
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 26,
                SellIn = 19
            };

            RunAsserts();
        }

        [TestMethod]
        public void TestConjuredItemUpdater()
        {
            GildedRoseItemImpl grItem = CreateGRItem("Conjured", 25, 20);
            GildedRoseItemUpdater grItemUpdater = new ConjuredItemUpdater(grItem);
            grItemUpdater.Update();

            inputItem = grItem.Value;

            outputItem = new Item()
            {
                Name = "Conjured",
                Quality = 23,
                SellIn = 19
            };

            RunAsserts();
        }

        [TestMethod]
        public void TestNormalItemUpdater()
        {
            GildedRoseItemImpl grItem = CreateGRItem("Normal Item", 25, 20);
            GildedRoseItemUpdater grItemUpdater = new NormalItemUpdater(grItem);
            grItemUpdater.Update();

            inputItem = grItem.Value;

            outputItem = new Item()
            {
                Name = "Normal Item",
                Quality = 24,
                SellIn = 19
            };

            RunAsserts();
        }

        [TestMethod]
        public void TestSulfurasItemUpdater()
        {
            GildedRoseItemImpl grItem = CreateGRItem("Sulfuras, Hand of Ragnaros", 65, 20);
            GildedRoseItemUpdater grItemUpdater = new SulfurasItemUpdater(grItem);
            grItemUpdater.Update();

            inputItem = grItem.Value;

            outputItem = new Item()
            {
                Name = "Sulfuras, Hand of Ragnaros",
                Quality = 80,
                SellIn = 20
            };

            RunAsserts();
        }

        [TestMethod]
        public void TestStubItemUpdater()
        {
            GildedRoseItemImpl grItem = CreateGRItem("", 30, 30);
            GildedRoseItemUpdater grItemUpdater = new StubItemUpdater(grItem);
            grItemUpdater.Update();

            inputItem = grItem.Value;

            outputItem = new Item()
            {
                Name = "",
                Quality = 30,
                SellIn = 30
            };

            RunAsserts();
        }

        private GildedRoseItemImpl CreateGRItem(string Name, int Quality, int SellIn)
        {
            Item inputItem = new Item()
            {
                Name = Name,
                Quality = Quality,
                SellIn = SellIn
            };
            return new GildedRoseItemImpl(inputItem);
        }

        private void RunAsserts()
        {
            Assert.AreEqual(outputItem.Name, inputItem.Name);
            Assert.AreEqual(outputItem.Quality, inputItem.Quality);
            Assert.AreEqual(outputItem.SellIn, inputItem.SellIn);
        }
    }
}
