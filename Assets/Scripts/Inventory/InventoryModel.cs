using System;
using System.Collections.Generic;
using UnityEngine;

namespace Systems.Inventory
{
    public class InventoryModel
    {
        private Slot[] _slots;
        private Slot _currentSelectedSlot;

        private int _currentSelectedSlotIndex = 0;

        public int CurrentSelectedSlotIndex => _currentSelectedSlotIndex;

        public Action<int> CurrentSelectedSlotChanged;

        public InventoryModel(Slot[] slots)
        {
            _slots = slots;
            _currentSelectedSlot = _slots[_currentSelectedSlotIndex];
        }

        public void SetCurrentSelectedSlot(int index)
        {
            //polish
            if (index < 0)
                index = _slots.Length - 1;
            else if (index > _slots.Length - 1)
                index = 0;

            _currentSelectedSlot = _slots[index];
            _currentSelectedSlotIndex = index;

            CurrentSelectedSlotChanged?.Invoke(_currentSelectedSlotIndex);
        }

        public void UseItem(ItemUseContext itemUseContext)
        {
            _currentSelectedSlot
                .GetItem()
                .Use(itemUseContext);
        }
    }
}

