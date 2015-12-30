
/*
 * File: NormalItemTest.cs
 * ------------------------
 * This file contains unit tests for normal items.
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
    public class NormalItemTest
    {
        private const string ITEM_NAME = "Normal Item";

        private Item inputItem;
        private Item outputItem;

        [TestMethod]
        public void TestDegradeQualityInOneDay()
        {
            InitInputItem(ITEM_NAME, 10, 15);
            CreateOutputItem();

            UpdateInputItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestQualityDoesntDropBelowZero()
        {
            InitInputItem(ITEM_NAME, 0, 10);
            CreateOutputItem();

            UpdateInputItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestAcceleratedDegradeQualityInOneDay()
        {
            InitInputItem(ITEM_NAME, 10, 0);
            CreateOutputItem();

            UpdateInputItem();

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
            NormalOutputItemBuilder outputItemBuilder = new NormalOutputItemBuilder(inputItem);
            outputItem = outputItemBuilder.Item;
        }

        private void UpdateInputItem()
        {
            GildedRoseItemImpl gildedRoseItem = new GildedRoseItemImpl(inputItem);
            NormalItemUpdater normalItemUpdater = new NormalItemUpdater(gildedRoseItem);
            normalItemUpdater.Update();

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
