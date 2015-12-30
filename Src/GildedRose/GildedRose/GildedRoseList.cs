
/*
 * File: GildedRoseList.cs
 * ------------------------
 * This file contains the definition for a GildedRose list.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose
{
    public class GildedRoseList : IEnumerable
    {
        private IList<GildedRoseItemImpl> Items = new List<GildedRoseItemImpl>();

        public void AddItem(GildedRoseItemImpl NewItem)
        {
            Items.Add(NewItem);
        }

        public GildedRoseItemImpl RemoveItem(int Index)
        {
            GildedRoseItemImpl item = Items[Index];
            Items.RemoveAt(Index);
            return item;
        }

        public int Count
        {
            get
            {
                return Items.Count;
            }
        }

        public GildedRoseItemImpl this[int Index]
        {
            get
            {
                return Items[Index];
            }
            set
            {
                Items[Index] = value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
