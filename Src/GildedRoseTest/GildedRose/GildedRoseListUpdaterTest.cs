
/*
 * File: GildedRoseListUpdaterTest.cs
 * -----------------------------------
 * This file contains unit tests for GildedRose list updater.
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
    public class GildedRoseListUpdaterTest
    {
        private GildedRoseListUpdater gildedRoseUpdatableList;

        [TestMethod]
        public void TestGRUpdatableListUnchangedCount()
        {
            GildedRoseList inputGildedRoseList = new GildedRoseList();
            GildedRoseList outputGildedRoseList = new GildedRoseList();

            gildedRoseUpdatableList = new GildedRoseListUpdaterImpl(inputGildedRoseList);

            Assert.AreEqual(outputGildedRoseList.Count, inputGildedRoseList.Count);
        }

    }
}
