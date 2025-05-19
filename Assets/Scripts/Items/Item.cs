using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Items/Item")]
public class Item : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private Sprite _icon;
    [SerializeField] private ItemBehaviorBase _behavior;

    public void Use(ItemUseContext itemUseContext)
    {
        _behavior.Use(itemUseContext);
    }
}
