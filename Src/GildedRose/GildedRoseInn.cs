
/*
 * File: GildedRoseInn.cs
 * -----------------------
 * This file contains the GildedRoseInn class. It updates all inventory items.
 */

using System.Collections.Generic;

namespace GildedRose
{
	public class GildedRoseInn
	{
        private GildedRoseListUpdater gildedRoseUpdater;

        public GildedRoseInn(GildedRoseList GRList)
        {
            gildedRoseUpdater = new GildedRoseListUpdaterImpl(GRList);
        }

        public void UpdateItems()
        {
            gildedRoseUpdater.UpdateAll();
        }
		
	}
	
}