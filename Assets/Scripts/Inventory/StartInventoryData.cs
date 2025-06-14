using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StartInventoryData", menuName = "Inventory/StartInventoryData")]
public class StartInventoryData : ScriptableObject
{
    public List<InventorySlotData> Items;
}

[Serializable]
public struct InventorySlotData
{
    public Item Item;

    [Min(1)]
    public int Count;
}