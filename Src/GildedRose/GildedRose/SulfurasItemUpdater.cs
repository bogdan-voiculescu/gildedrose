
/*
 * File: SulfurasItemUpdater.cs
 * -----------------------------
 * This file contains the definition for sulfuras item updater.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose
{
    public class SulfurasItemUpdater : GildedRoseItemUpdater
    {
        private const int DEFAULT_QUALITY = 80;

        private GildedRoseItemImpl gildedRoseItem;

        public SulfurasItemUpdater(GildedRoseItemImpl GRItem)
        {
            gildedRoseItem = GRItem;
        }

        public void Update()
        {
            UpdateQuality();
        }

        private void UpdateQuality()
        {
            Item agedBrieItem = gildedRoseItem.Value;
            agedBrieItem.Quality = DEFAULT_QUALITY;
        }
    }
}
