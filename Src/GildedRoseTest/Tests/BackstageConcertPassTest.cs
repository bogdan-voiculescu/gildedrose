﻿
/*
 * File: BackstageConcertPassTest.cs
 * ----------------------------------
 * This file contains unit tests for backstage passes to a TAFKAL80ETC concert items.
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
    public class BackstageConcertPassTest
    {
        private const string ITEM_NAME = "Backstage passes to a TAFKAL80ETC concert";

        private Item inputItem;
        private Item outputItem;

        [TestMethod]
        public void TestUpdateQualityByOne()
        {
            InitInputItem(ITEM_NAME, 10, 15);
            CreateOutputItem();

            RunUpdateQualityForItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestUpdateQualityByTwo()
        {
            InitInputItem(ITEM_NAME, 10, 10);
            CreateOutputItem();

            RunUpdateQualityForItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestUpdateQualityByThree()
        {
            InitInputItem(ITEM_NAME, 10, 5);
            CreateOutputItem();

            RunUpdateQualityForItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestUpdateQualityToNil()
        {
            InitInputItem(ITEM_NAME, 10, 0);
            CreateOutputItem();

            RunUpdateQualityForItem();

            RunAsserts();
        }

        [TestMethod]
        public void TestUpdateMaxQuality()
        {
            InitInputItem(ITEM_NAME, 50, 15);
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
            BackstageConcertPassOutputItemBuilder outputItemBuilder = new BackstageConcertPassOutputItemBuilder(inputItem);
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
