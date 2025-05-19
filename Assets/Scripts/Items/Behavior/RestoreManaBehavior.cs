using UnityEngine;

[CreateAssetMenu(fileName = "RestoreManaBehavior", menuName = "Items/Behaviors/RestoreMana")]
public class RestoreManaBehavior : ItemBehaviorBase
{
    [SerializeField] private readonly int _restoreManaAmount;

    public override void Use(ItemUseContext itemUseContext)
    {
        int manaValue = Mathf.Max(0, _restoreManaAmount);

        if (_restoreManaAmount < 0)
            Debug.LogWarning($"[RestoreManaBehavior] Restore mana amount is less than zero: {_restoreManaAmount}");

        Player player = itemUseContext.Player;
        player.ModifyStatValue(StatType.Mana, manaValue);
    }
}
