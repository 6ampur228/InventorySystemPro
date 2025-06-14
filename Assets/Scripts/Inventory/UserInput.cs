using UnityEngine;

namespace Systems.Inventory
{
    public class UserInput : MonoBehaviour
    {
        [SerializeField] private InventoryController _controller;

        private InventoryModel _model;
        private ItemUseContext _context;

        private void Start()
        {
            _model = _controller._model;
            _context = new ItemUseContext();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                _model.SetCurrentSelectedSlot(_model.CurrentSelectedSlotIndex - 1);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {

                _controller._model.SetCurrentSelectedSlot(_model.CurrentSelectedSlotIndex + 1);

            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                _model.UseItem(_context);
            }
        }
    }
}