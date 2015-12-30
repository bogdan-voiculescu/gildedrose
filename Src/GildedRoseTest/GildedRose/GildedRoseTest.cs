
/*
 * File: GildedRoseTest.cs
 * ------------------------
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
    public class GildedRoseTest
    {
        private Item inputItem;
        private Item outputItem;

        [TestMethod]
        public void TestCreateGildedRose()
        {
            GildedRoseList grList = new GildedRoseList();
            grList.AddItem(CreateGRItem("Aged Brie", 25, 20));

            GildedRose.GildedRoseInn gildedRose = new GildedRose.GildedRoseInn(grList);
            Assert.IsNotNull(gildedRose);
        }

        [TestMethod]
        public void TestUpdateItems()
        {
            GildedRoseItemImpl[] inputItemArray = new GildedRoseItemImpl[]
            {
                CreateGRItem("Aged Brie", 25, 10),
                CreateGRItem("Aged Brie", 25, 20),
                CreateGRItem("Backstage passes to a TAFKAL80ETC concert", 25, 20),
                CreateGRItem("Sulfuras, Hand of Ragnaros", 25, 20),
                CreateGRItem("Conjured", 25, 20),
                CreateGRItem("Normal Item", 25, 20),
                CreateGRItem("Normal Item", 25, 20)
            };

            GildedRoseItemImpl[] outputItemArray = new GildedRoseItemImpl[]
            {
                new GildedRoseItemImpl(new AgedBrieOutputItemBuilder(inputItemArray[0].Value).Item),
                new GildedRoseItemImpl(new AgedBrieOutputItemBuilder(inputItemArray[1].Value).Item),
                new GildedRoseItemImpl(new BackstageConcertPassOutputItemBuilder(inputItemArray[2].Value).Item),
                new GildedRoseItemImpl(new SulfurasOutputItemBuilder(inputItemArray[3].Value).Item),
                new GildedRoseItemImpl(new ConjuredOutputItemBuilder(inputItemArray[4].Value).Item),
                new GildedRoseItemImpl(new NormalOutputItemBuilder(inputItemArray[5].Value).Item),
                new GildedRoseItemImpl(new NormalOutputItemBuilder(inputItemArray[6].Value).Item)
            };

            GildedRoseList grList = new GildedRoseList();
            foreach (GildedRoseItemImpl item in inputItemArray)
            {
                grList.AddItem(item);
            }

            GildedRose.GildedRoseInn gildedRose = new GildedRose.GildedRoseInn(grList);
            gildedRose.UpdateItems();

            for (int i = 0; i < grList.Count; i++)
            {
                inputItem = grList[i].Value;
                outputItem = outputItemArray[i].Value;

                RunAsserts();
            }
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
