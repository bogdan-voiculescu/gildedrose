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
        [TestMethod]
        public void TestMethod1()
        {
            List<Item> emptyList = new List<Item>();
            GildedRose.GildedRose gildedRose = new GildedRose.GildedRose(emptyList);
            gildedRose.UpdateQuality();
        }
    }
}
