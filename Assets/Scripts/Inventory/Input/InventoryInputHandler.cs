using System;
using UnityEngine;

public class InventoryInputHandler : MonoBehaviour
{
    private PlayerInput _playerinput;

    public event Action UseItemPressed;
    public event Action<int> ChangeSlotPressed;

    private void Awake()
    {
        _playerinput = new PlayerInput();

        _playerinput.Inventory.UseItem.performed += ctx => UseItemPressed?.Invoke();
        _playerinput.Inventory.ChangeSlot.performed += ctx => ChangeSlotPressed?.Invoke((int)ctx.ReadValue<float>());
    }

    private void OnEnable() => _playerinput.Enable();
    private void OnDisable() => _playerinput.Disable();
}
