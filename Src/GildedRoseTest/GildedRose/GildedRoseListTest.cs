
/*
 * File: GildedRoseListTest.cs
 * ----------------------------
 * This file contains unit tests for GildedRose list.
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
    public class GildedRoseListTest
    {
        private GildedRoseList gildedRoseList = new GildedRoseList(); 

        [TestMethod]
        public void TestCreateEmptyGRList()
        {
            AssertGRListCount(0);
        }

        [TestMethod]
        public void TestAddOneItemToGRList()
        {
            AddNewGRItemToGRList("Aged Brie", 20, 20);
            AssertGRListCount(1);
        }

        [TestMethod]
        public void TestRemoveOneItemFromGRList()
        {
            AddNewGRItemToGRList("Aged Brie", 20, 20);
            gildedRoseList.RemoveItem(0);
            AssertGRListCount(0);
        }

        [TestMethod]
        public void TestGRListIsEnumerable()
        {
            for (int i = 0; i < 5; i++)
            {
                AddNewGRItemToGRList("Aged Brie", 20, 20);
            }

            foreach (GildedRoseItemImpl item in gildedRoseList)
            {
                Assert.IsNotNull(item);
            }
        }

        private void AddNewGRItemToGRList(string Name, int Quality, int SellIn)
        {
            gildedRoseList.AddItem(CreateGRItem(Name, Quality, SellIn));
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

        private void AssertGRListCount(int value)
        {
            Assert.AreEqual(value, gildedRoseList.Count);
        }
    }
}
