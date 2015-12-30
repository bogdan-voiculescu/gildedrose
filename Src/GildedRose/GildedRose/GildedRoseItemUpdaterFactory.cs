
/*
 * File: GildedRoseItemUpdaterFactory.cs
 * --------------------------------------
 * This file contains the definition for class that creates GuildedRose item updater of different kinds.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose
{
    public class GildedRoseItemUpdaterFactory
    {
        public static GildedRoseItemUpdater CreateUpdaterFor(GildedRoseItemImpl gildedRoseItem)
        {
            Item item = gildedRoseItem.Value;
            switch (item.Name)
            {
                case "Aged Brie":
                {
                    return new AgedBrieItemUpdater(gildedRoseItem);
                }
                case "Backstage passes to a TAFKAL80ETC concert":
                {
                    return new BackstageConcertPassItemUpdater(gildedRoseItem);
                }
                case "Conjured":
                {
                    return new ConjuredItemUpdater(gildedRoseItem);
                }
                case "Normal Item":
                {
                    return new NormalItemUpdater(gildedRoseItem);
                }
                case "Sulfuras, Hand of Ragnaros":
                {
                    return new SulfurasItemUpdater(gildedRoseItem);
                }
                default:
                {
                    return new StubItemUpdater(gildedRoseItem);
                }
            }
        }
    }
}
