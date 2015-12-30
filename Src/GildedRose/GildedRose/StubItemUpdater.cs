
/*
 * File: StubItemUpdater.cs
 * -------------------------
 * This file contains the definition for stub item updater.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose
{
    public class StubItemUpdater : GildedRoseItemUpdater
    {
        private GildedRoseItemImpl gildedRoseItem;

        public StubItemUpdater(GildedRoseItemImpl GRItem)
        {
            gildedRoseItem = GRItem;
        }

        public void Update()
        {
            
        }
    }
}
