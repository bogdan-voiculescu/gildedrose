
/*
 * File: AgedBrieItemUpdater.cs
 * -----------------------------
 * This file contains the definition for Aged Brie item updater.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose
{
    public class AgedBrieItemUpdater : GildedRoseItemUpdater
    {
        private GildedRoseItemImpl gildedRoseItem;

        public AgedBrieItemUpdater(GildedRoseItemImpl GRItem)
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
            Item agedBrieItem = gildedRoseItem.Value;
            agedBrieItem.SellIn--;
        }

        private void UpdateQuality()
        {
            Item agedBrieItem = gildedRoseItem.Value;

            if (agedBrieItem.SellIn < 1)
            {
                agedBrieItem.Quality = 0;
            }
            else if (agedBrieItem.SellIn <= 5)
            {
                agedBrieItem.Quality = agedBrieItem.Quality + 3;
            }
            else if (agedBrieItem.SellIn <= 10)
            {
                agedBrieItem.Quality = agedBrieItem.Quality + 2;
            }
            else
            {
                agedBrieItem.Quality = agedBrieItem.Quality + 1;
            }

            if (agedBrieItem.Quality > 50)
            {
                agedBrieItem.Quality = 50;
            }
        }
    }
}
