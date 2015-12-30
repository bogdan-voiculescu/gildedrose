
/*
 * File: GildedRoseUpdatableList.cs
 * ---------------------------------
 * This file contains the interface for a GildedRose item collection type that can perform updates.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose
{
    public class GildedRoseListUpdaterImpl : GildedRoseListUpdater
    {
        private GildedRoseList gildedRoseList;

        public GildedRoseListUpdaterImpl(GildedRoseList GRList)
        {
            gildedRoseList = GRList;
        }

        public void UpdateAll()
        {
            foreach (GildedRoseItemImpl gildedRoseItem in gildedRoseList)
            {
                GildedRoseItemUpdater gildedRoseItemUpdater = GildedRoseItemUpdaterFactory.CreateUpdaterFor(gildedRoseItem);
                gildedRoseItemUpdater.Update();
            }
        }
    }
}
