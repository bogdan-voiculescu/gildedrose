﻿
/*
 * File: SulfurasTest.cs
 * ----------------------
 * This file contains unit tests for sulfuras items.
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
    public class SulfurasTest
    {
        private const string ITEM_NAME = "Sulfuras, Hand of Ragnaros";

        private Item inputItem;
        private Item outputItem;

        [TestMethod]
        public void TestSameQualityMoreThanTenDays()
        {
            InitInputItem(ITEM_NAME, 10, 15);
            CreateOutputItem();

            UpdateInputItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestSameQualityLastTenDays()
        {
            InitInputItem(ITEM_NAME, 10, 10);
            CreateOutputItem();

            UpdateInputItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestSameQualityLastFiveDays()
        {
            InitInputItem(ITEM_NAME, 10, 5);
            CreateOutputItem();

            UpdateInputItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestSameQualityNegativeSellIn()
        {
            InitInputItem(ITEM_NAME, 10, -1);
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
            SulfurasOutputItemBuilder outputItemBuilder = new SulfurasOutputItemBuilder(inputItem);
            outputItem = outputItemBuilder.Item;
        }

        private void UpdateInputItem()
        {
            GildedRoseItemImpl gildedRoseItem = new GildedRoseItemImpl(inputItem);
            SulfurasItemUpdater sulfurasItemUpdater = new SulfurasItemUpdater(gildedRoseItem);
            sulfurasItemUpdater.Update();

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
