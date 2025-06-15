using UnityEngine;
using Cysharp.Threading.Tasks;

namespace Systems.Inventory
{
    public class InventoryController : MonoBehaviour
    {
        [SerializeField] private InventoryInputHandler _inputHandler;

        [SerializeField] private StartInventoryData _startInventoryData;
        [SerializeField] private InventoryView _view;

        public InventoryModel _model;

        private void Awake()
        {
            Slot[] startSlots = GetStartSlots(_startInventoryData);
            Slot[] startSlotsClone = startSlots.DeepClone();

            _model = new InventoryModel(startSlots);

            InitializeViewAsync(startSlotsClone).Forget();     
        }

        private void OnEnable()
        {
            _model.ItemUsed += OnItemUsed;

            _inputHandler.UseItemPressed += OnUseItemPressed;
            _inputHandler.ChangeSlotPressed += OnChangeSlotPressed;
        }

        private void OnDisable()
        {
            _model.ItemUsed -= OnItemUsed;

            _inputHandler.UseItemPressed -= OnUseItemPressed;
            _inputHandler.ChangeSlotPressed -= OnChangeSlotPressed;
        }

        private void OnItemUsed(int qty, int index)
        {
            _view.RefreshSlotView(qty, index);
        }

        private void OnUseItemPressed() => _model.UseItem();

        private void OnChangeSlotPressed(int direction) 
        {
            int nextSlotIndex = _model.CurrentSelectedSlotIndex + direction;
            int wrapedNextSlotIndex = WrapSlotIndex(nextSlotIndex, _model.SlotCount);
            
            _model.ChangeCurrentSelectedSlot(wrapedNextSlotIndex);
            _view.ChangeSelectedSlotView(wrapedNextSlotIndex);
        }

        private int WrapSlotIndex(int index, int slotCount)
        {
            if (index < 0)
                index = slotCount - 1;
            else if (index > slotCount - 1)
                index = 0;

            return index;
        }

        #region Initialize
        private async UniTaskVoid InitializeViewAsync(Slot[] startSlotsClone) 
        { 
            await _view.InitializeViewAsync(startSlotsClone); 
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
        #endregion
    }
}

