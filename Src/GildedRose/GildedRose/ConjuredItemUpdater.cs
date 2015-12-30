
/*
 * File: ConjuredItemUpdater.cs
 * -----------------------------
 * This file contains the definition for conjured item updater.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose
{
    public class ConjuredItemUpdater : GildedRoseItemUpdater
    {
        private GildedRoseItemImpl gildedRoseItem;

        public ConjuredItemUpdater(GildedRoseItemImpl GRItem)
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
            Item conjuredItem = gildedRoseItem.Value;
            conjuredItem.SellIn--;
        }

        private void UpdateQuality()
        {
            Item conjuredItem = gildedRoseItem.Value;

            if (conjuredItem.SellIn < 1)
            {
                conjuredItem.Quality -= 4;
            }
            else 
            {
                conjuredItem.Quality -= 2;
            }
        }
    }
}
