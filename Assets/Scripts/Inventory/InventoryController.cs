using System.Collections;
using UnityEngine;

namespace Systems.Inventory
{
    public class InventoryController : MonoBehaviour
    {
        [SerializeField] private StartInventoryData _startInventoryData;
        [SerializeField] private InventoryView _view;

        public InventoryModel _model;

        private void Awake()
        {
            Slot[] startSlots = GetStartSlots(_startInventoryData);
            Slot[] startSlotsClone = startSlots.DeepClone();

            _model = new InventoryModel(startSlots);

            StartCoroutine(_view.InitializeView(startSlotsClone));
        }

        private void OnEnable()
        {
            _model.CurrentSelectedSlotChanged += OnCurrentSelectedSlotChanged;
        }

        private void OnDisable()
        {
            _model.CurrentSelectedSlotChanged -= OnCurrentSelectedSlotChanged;
        }

        private void OnCurrentSelectedSlotChanged(int changedSlotIndex)
        {
            _view.ChangeSelectedSlotView(changedSlotIndex);
        }

        private Slot[] GetStartSlots(StartInventoryData startInventoryData)
        {
            Slot[] startSlots = new Slot[startInventoryData.Items.Count];

            for (int i = 0; i < startInventoryData.Items.Count; i++)
            {
                Item item = startInventoryData.Items[i].Item;
                int qty = startInventoryData.Items[i].Count;

                startSlots[i] = new Slot(item, qty);
            }

            return startSlots;
        }
    }
}

