using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Systems.Inventory
{
    public class Slot : ICloneable
    {
        private Item _item;
        private int _qtyItem;

        public int QtyItem => _qtyItem;

        public Slot(Item item, int qtyItem = 1)
        {
            _item = item;
            _qtyItem = qtyItem;
        }

        public Item GetItem()
        {
            return _item.Clone();
        }

        object ICloneable.Clone()
        {
            return new Slot(_item.Clone(), _qtyItem);
        }
    }
}