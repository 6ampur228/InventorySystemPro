using System;

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

        public void UseItem(/*ItemUseContext ctx*/)
        {
            _item?.Use(/*ctx*/);
            _qtyItem--;

            if(_qtyItem == 0)
                _item = null;
        }

        public Item GetItem()
        {
            return _item;
        }

        public object Clone()
        {
            return new Slot(_item, _qtyItem);
        }
    }
}