
/*
 * File: GildedRoseItemImpl.cs
 * ----------------------------
 * This file contains the implementation for a GildedRose item.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose
{
    public class GildedRoseItemImpl : GildedRoseItem<Item>
    {
        private Item value;

        public GildedRoseItemImpl(Item Item)
        {
            value = new Item()
            {
                Name = Item.Name,
                Quality = Item.Quality,
                SellIn = Item.SellIn
            };
        }

        public Item Value
        {
            get
            {
                return value;
            }
        }
    }
}
