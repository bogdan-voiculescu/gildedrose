
/*
 * File: BackstageConcertPassItemUpdater.cs
 * -----------------------------------------
 * This file contains the definition for backstage concert pass item updater.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose
{
    public class BackstageConcertPassItemUpdater : GildedRoseItemUpdater
    {
        private GildedRoseItemImpl gildedRoseItem;

        public BackstageConcertPassItemUpdater(GildedRoseItemImpl GRItem)
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
            Item backstageConcertPassItem = gildedRoseItem.Value;
            backstageConcertPassItem.SellIn--;
        }

        private void UpdateQuality()
        {
            Item backstageConcertPassItem = gildedRoseItem.Value;

            if (backstageConcertPassItem.SellIn < 1)
            {
                backstageConcertPassItem.Quality = 0;
            }
            else if (backstageConcertPassItem.SellIn <= 5)
            {
                backstageConcertPassItem.Quality = backstageConcertPassItem.Quality + 3;
            }
            else if (backstageConcertPassItem.SellIn <= 10)
            {
                backstageConcertPassItem.Quality = backstageConcertPassItem.Quality + 2;
            }
            else
            {
                backstageConcertPassItem.Quality = backstageConcertPassItem.Quality + 1;
            }

            if (backstageConcertPassItem.Quality > 50)
            {
                backstageConcertPassItem.Quality = 50;
            }
        }
    }
}
