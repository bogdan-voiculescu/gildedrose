
/*
 * File: SulfurasOutputItemBuilder.cs
 * -----------------------------------
 * This file contains the builder definition for a sulfuras output item used in unit tests.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GildedRose;

namespace GildedRoseTest
{
    public class SulfurasOutputItemBuilder
    {
        private const int DEFAULT_QUALITY = 80;

        private Item OutputItem;

        public SulfurasOutputItemBuilder(Item InputItem)
        {
            BuildOutputItem(InputItem);
        }

        private void BuildOutputItem(Item InputItem)
        {
            OutputItem = new Item()
            {
                Name = InputItem.Name,
                Quality = DEFAULT_QUALITY,
                SellIn = InputItem.SellIn
            };
        }

        public Item Item
        {
            get
            {
                return OutputItem;
            }
        }
    }
}
