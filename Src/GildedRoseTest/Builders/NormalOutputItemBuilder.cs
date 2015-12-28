
/*
 * File: NormalOutputItemBuilder.cs
 * ---------------------------------
 * This file contains the builder definition for a normal output item used in unit tests.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GildedRose;

namespace GildedRoseTest
{
    public class NormalOutputItemBuilder
    {
        private Item OutputItem;

        public NormalOutputItemBuilder(Item InputItem)
        {
            BuildOutputItem(InputItem);
        }

        private void BuildOutputItem(Item InputItem)
        {
            OutputItem = new Item()
            {
                Name = InputItem.Name,
                SellIn = InputItem.SellIn - 1,
                Quality = (((InputItem.SellIn - 1) < 0) || (InputItem.Quality < 1)) ? 0 : (InputItem.Quality - 1)
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
