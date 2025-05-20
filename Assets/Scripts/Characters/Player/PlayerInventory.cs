using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private List<Item> _items;

    private Item _currentSelectedItem;

    public void UseItem(ItemUseContext itemUseContext)
    {
        _currentSelectedItem.Use(itemUseContext);
    }
}
