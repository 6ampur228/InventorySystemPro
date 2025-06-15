using UnityEngine;
using UnityEngine.UIElements;
using Cysharp.Threading.Tasks;

namespace Systems.Inventory
{
    public class InventoryView : StorageView
    {
        [SerializeField] private string _panelName = "Inventory";

        private int _currentSelectedSlotViewIndex = 0;

        public override async UniTask InitializeViewAsync(Slot[] slots)
        {
            _slotViews = new SlotView[slots.Length];

            _root = _document.rootVisualElement;
            _root.Clear();
            _root.styleSheets.Add(_styleSheet);

            _container = _root.CreateChild("container");

            var inventory = _container.CreateChild("inventory");
            inventory.CreateChild("inventoryFrame");
            inventory.CreateChild("inventoryHeader").Add(new Label(_panelName));

            await InitializeSlotViewAsync(inventory, slots);

            _slotViews[_currentSelectedSlotViewIndex].Select();
        }

        private async UniTask InitializeSlotViewAsync(VisualElement inventory, Slot[] slots)
        {
            var slotsContainer = inventory.CreateChild("slotsContainer");
            for (int i = 0; i < _slotViews.Length; i++)
            {
                var slot = slotsContainer.CreateChild<SlotView>("slotView");

                _slotViews[i] = slot;
                _slotViews[i].Set(slots[i]);

                await UniTask.Delay(30);
            }
        }

        public void ChangeSelectedSlotView(int index)
        {
            _slotViews[_currentSelectedSlotViewIndex].Unselect();
            _slotViews[index].Select();
            _currentSelectedSlotViewIndex = index;
        }

        public void RefreshSlotView(int qty, int index)
        {
            if(qty == 0)
            {
                _slotViews[index].Remove();
                return;
            }

            _slotViews[index].UpdateStackLabel(qty);
        }
    }
}