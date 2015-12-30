
/*
 * File: NormalItemUpdater.cs
 * ---------------------------
 * This file contains the definition for normal item updater.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose
{
    public class NormalItemUpdater : GildedRoseItemUpdater
    {
        private GildedRoseItemImpl gildedRoseItem;

        public NormalItemUpdater(GildedRoseItemImpl GRItem)
        {
            gildedRoseItem = GRItem;
        }

        public void Update()
        {
            UpdateSellIn();
            UpdateQuality();
        }

        private void UpdateSellIn()
        {
            Item normalItem = gildedRoseItem.Value;
            normalItem.SellIn--;
        }

        private void UpdateQuality()
        {
            Item normalItem = gildedRoseItem.Value;
            
            int qualityDegradeValue = (normalItem.SellIn < 0) ? 2 : 1;
            normalItem.Quality -= qualityDegradeValue;

            if (normalItem.Quality < 0)
            {
                normalItem.Quality = 0;
            }
        }
    }
}
