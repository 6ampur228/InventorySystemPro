using System;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Items/Item")]
public class Item : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private ItemBehaviorBase _behavior;

    public Sprite Sprite => _sprite;

    public Item Clone()
    {
        return Instantiate(this);
    }

    public void Use(ItemUseContext itemUseContext)
    {
        _behavior.Use(itemUseContext);
    }

}
