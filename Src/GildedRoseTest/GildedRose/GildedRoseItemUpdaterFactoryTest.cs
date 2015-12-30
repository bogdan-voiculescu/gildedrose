
/*
 * File: GildedRoseItemUpdaterFactoryTest.cs
 * ------------------------------------------
 * This file contains unit tests for class that creates GildedRose item updater of different kinds.
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
    public class GildedRoseItemUpdaterFactoryTest
    {
        private GildedRoseItemUpdater gildedRoseItemUpdater;

        [TestMethod]
        public void TestCreateAgedBrieItemUpdater()
        {
            Item item = new Item()
            {
                Name = "Aged Brie",
                Quality = 26,
                SellIn = 19
            };
            GildedRoseItemImpl gildedRoseItem = new GildedRoseItemImpl(item);
            AgedBrieItemUpdater agedBrieItemUpdater = new AgedBrieItemUpdater(gildedRoseItem);

            CreateUpdaterFor(gildedRoseItem);

            RunAssertInstanceOfType(agedBrieItemUpdater.GetType());
        }

        [TestMethod]
        public void TestCreateBackstageConcertPassUpdater()
        {
            Item item = new Item()
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 26,
                SellIn = 19
            };
            GildedRoseItemImpl gildedRoseItem = new GildedRoseItemImpl(item);
            BackstageConcertPassItemUpdater backstageConcertPassItemUpdater = new BackstageConcertPassItemUpdater(gildedRoseItem);

            CreateUpdaterFor(gildedRoseItem);

            RunAssertInstanceOfType(backstageConcertPassItemUpdater.GetType());
        }

        [TestMethod]
        public void TestCreateConjuredItemUpdater()
        {
            Item item = new Item()
            {
                Name = "Conjured",
                Quality = 23,
                SellIn = 19
            };
            GildedRoseItemImpl gildedRoseItem = new GildedRoseItemImpl(item);
            ConjuredItemUpdater conjuredItemUpdater = new ConjuredItemUpdater(gildedRoseItem);

            CreateUpdaterFor(gildedRoseItem);

            RunAssertInstanceOfType(conjuredItemUpdater.GetType());
        }

        [TestMethod]
        public void TestCreateNormalItemUpdater()
        {
            Item item = new Item()
            {
                Name = "Normal Item",
                Quality = 24,
                SellIn = 19
            };
            GildedRoseItemImpl gildedRoseItem = new GildedRoseItemImpl(item);
            NormalItemUpdater normalItemUpdater = new NormalItemUpdater(gildedRoseItem);

            CreateUpdaterFor(gildedRoseItem);

            RunAssertInstanceOfType(normalItemUpdater.GetType());
        }

        [TestMethod]
        public void TestCreateSulfurasItemUpdater()
        {
            Item item = new Item()
            {
                Name = "Sulfuras, Hand of Ragnaros",
                Quality = 80,
                SellIn = 20
            };
            GildedRoseItemImpl gildedRoseItem = new GildedRoseItemImpl(item);
            SulfurasItemUpdater sulfurasItemUpdater = new SulfurasItemUpdater(gildedRoseItem);

            CreateUpdaterFor(gildedRoseItem);

            RunAssertInstanceOfType(sulfurasItemUpdater.GetType());
        }

        [TestMethod]
        public void TestCreateStubItemUpdater()
        {
            Item item = new Item()
            {
                Name = "",
                Quality = 30,
                SellIn = 30
            };
            GildedRoseItemImpl gildedRoseItem = new GildedRoseItemImpl(item);
            StubItemUpdater stubItemUpdater = new StubItemUpdater(gildedRoseItem);

            CreateUpdaterFor(gildedRoseItem);

            RunAssertInstanceOfType(stubItemUpdater.GetType());
        }

        private void CreateUpdaterFor(GildedRoseItemImpl item)
        {
            gildedRoseItemUpdater = GildedRoseItemUpdaterFactory.CreateUpdaterFor(item);
        }

        private void RunAssertInstanceOfType(Type type)
        {
            Assert.IsInstanceOfType(gildedRoseItemUpdater, type);
        }
    }
}
