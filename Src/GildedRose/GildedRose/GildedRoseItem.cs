
/*
 * File: GildedRoseItem.cs
 * ------------------------
 * This file contains the interface for GildedRose item. It provides access to item data.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose
{
    public interface GildedRoseItem<ValueType>
    {
        ValueType Value
        {
            get;
        }
    }
}
