
/*
 * File: Item.cs
 * --------------
 * This file contains the Item data structure. It has 3 fields: Name, SellIn and Quality.
 * The fields are:
 * - Name
 * - SellIn: number of days to sell the item
 * - Quality
 */

using System;

namespace GildedRose
{
    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }
}
