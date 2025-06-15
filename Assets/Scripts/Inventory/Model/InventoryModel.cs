using System;

namespace Systems.Inventory
{
    public class InventoryModel
    {
        private Slot[] _slots;
        private Slot _currentSelectedSlot;

        private int _currentSelectedSlotIndex = 0;

        public event Action<int, int> ItemUsed;

        public int CurrentSelectedSlotIndex => _currentSelectedSlotIndex;
        public int SlotCount => _slots.Length;

        public InventoryModel(Slot[] slots)
        {
            _slots = slots;
            _currentSelectedSlot = _slots[_currentSelectedSlotIndex];
        }

        public void ChangeCurrentSelectedSlot(int index)
        {
            _currentSelectedSlot = _slots[index];
            _currentSelectedSlotIndex = index;
        }

        public void UseItem(/*ItemUseContext itemUseContext*/)
        {
            _currentSelectedSlot.UseItem(/*ItemUseContext itemUseContext*/);

            int qty = _currentSelectedSlot.QtyItem;

            ItemUsed?.Invoke(qty, _currentSelectedSlotIndex);
        }
    }
}

