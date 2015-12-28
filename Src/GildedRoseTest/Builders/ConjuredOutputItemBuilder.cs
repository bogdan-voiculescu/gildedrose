
/*
 * File: ConjuredOutputItemBuilder.cs
 * -----------------------------------
 * This file contains the builder definition for a conjured output item used in unit tests.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GildedRose;

namespace GildedRoseTest
{
    public class ConjuredOutputItemBuilder
    {
        private const int DEFAULT_QUALITY = 80;

        private Item OutputItem;

        public ConjuredOutputItemBuilder(Item InputItem)
        {
            BuildOutputItem(InputItem);
        }

        private void BuildOutputItem(Item InputItem)
        {
            OutputItem = new Item()
            {
                Name = InputItem.Name,
                Quality = (InputItem.SellIn < 1) ? (InputItem.Quality - 4) : (InputItem.Quality - 2),
                SellIn = InputItem.SellIn - 1
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
