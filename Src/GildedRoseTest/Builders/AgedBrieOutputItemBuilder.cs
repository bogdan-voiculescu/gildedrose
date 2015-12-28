
/*
 * File: AgedBrieOutputItemBuilder.cs
 * -----------------------------------
 * This file contains the builder definition for an aged brie output item used in unit tests.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GildedRose;

namespace GildedRoseTest
{
    public class AgedBrieOutputItemBuilder
    {
        private Item OutputItem;

        public AgedBrieOutputItemBuilder(Item InputItem)
        {
            BuildOutputItem(InputItem);
        }

        private void BuildOutputItem(Item InputItem)
        {
            OutputItem = new Item()
            {
                Name = InputItem.Name,
                Quality = ComputeQuality(InputItem),
                SellIn = InputItem.SellIn - 1
            };
        }

        private int ComputeQuality(Item InputItem)
        {
            int quality = -1;

            if (InputItem.SellIn < 1)
            {
                quality = 0;
            }
            else if (InputItem.SellIn <= 5)
            {
                quality = InputItem.Quality + 3;
            }
            else if (InputItem.SellIn <= 10)
            {
                quality = InputItem.Quality + 2;
            }
            else
            {
                quality = InputItem.Quality + 1;
            }

            if (quality > 50)
            {
                quality = 50;
            }

            return quality;
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
