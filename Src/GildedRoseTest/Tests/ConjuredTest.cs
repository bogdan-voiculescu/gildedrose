
/*
 * File: ConjuredTest.cs
 * ----------------------
 * This file contains unit tests for conjured items.
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
    public class ConjuredTest
    {
        private const string ITEM_NAME = "Conjured";

        private Item inputItem;
        private Item outputItem;

        [TestMethod]
        public void TestDegradeQualityInOneDay()
        {
            InitInputItem(ITEM_NAME, 10, 15);
            CreateOutputItem();

            RunUpdateQualityForItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestAcceleratedDegradeQualityInOneDay()
        {
            InitInputItem(ITEM_NAME, 10, 0);
            CreateOutputItem();

            RunUpdateQualityForItem();

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
            ConjuredOutputItemBuilder outputItemBuilder = new ConjuredOutputItemBuilder(inputItem);
            outputItem = outputItemBuilder.Item;
        }

        private void RunUpdateQualityForItem()
        {
            GildedRoseItemImpl gildedRoseItem = new GildedRoseItemImpl(inputItem);
            GildedRoseList gildedRoseList = new GildedRoseList();
            gildedRoseList.AddItem(gildedRoseItem);

            GildedRose.GildedRoseInn gildedRose = new GildedRose.GildedRoseInn(gildedRoseList);
            gildedRose.UpdateItems();

            inputItem = gildedRoseItem.Value;
        }

        private void RunAsserts()
        {
            Assert.AreEqual(outputItem.Name, inputItem.Name);
            Assert.AreEqual(outputItem.Quality, inputItem.Quality);
            Assert.AreEqual(outputItem.SellIn, inputItem.SellIn);
        }
    }
}
