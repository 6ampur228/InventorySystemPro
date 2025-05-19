using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private Item _currentSelectedItem;

    public void UseItem(ItemUseContext itemUseContext)
    {
        _currentSelectedItem.Use(itemUseContext);
    }
}
