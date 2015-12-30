
/*
 * File: AgedBrieTest.cs
 * ----------------------
 * This file contains unit tests for an Aged Brie item.
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
        private const string ITEM_NAME = "Aged Brie";

        private Item inputItem;
        private Item outputItem;
        
        [TestMethod]
        public void TestUpdateQualityByOne()
        {
            InitInputItem(ITEM_NAME, 10, 15);
            CreateOutputItem();

            UpdateInputItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestUpdateQualityByTwo()
        {
            InitInputItem(ITEM_NAME, 10, 10);
            CreateOutputItem();

            UpdateInputItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestUpdateQualityByThree()
        {
            InitInputItem(ITEM_NAME, 10, 5);
            CreateOutputItem();

            UpdateInputItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestUpdateQualityToNil()
        {
            InitInputItem(ITEM_NAME, 10, 0);
            CreateOutputItem();

            UpdateInputItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestUpdateMaxQuality()
        {
            InitInputItem(ITEM_NAME, 50, 15);
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
            AgedBrieOutputItemBuilder outputItemBuilder = new AgedBrieOutputItemBuilder(inputItem);
            outputItem = outputItemBuilder.Item;
        }

        private void UpdateInputItem()
        {
            GildedRoseItemImpl gildedRoseItem = new GildedRoseItemImpl(inputItem);
            AgedBrieItemUpdater agedBrieItemUpdater = new AgedBrieItemUpdater(gildedRoseItem);
            agedBrieItemUpdater.Update();

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
