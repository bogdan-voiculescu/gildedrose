
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
            int newSellIn = InputItem.SellIn - 1;
            OutputItem = new Item()
            {
                Name = InputItem.Name,
                SellIn = newSellIn,
                Quality = RecalculateQualityBasedOn(newSellIn, InputItem.Quality)
            };
        }

        private int RecalculateQualityBasedOn(int NewSellIn, int InputQuality)
        {
            int qualityDegradeValue = (NewSellIn < 0) ? 2 : 1;
            int quality = (InputQuality < qualityDegradeValue) ? InputQuality : (InputQuality - qualityDegradeValue);

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
