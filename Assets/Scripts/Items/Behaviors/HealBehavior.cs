using UnityEngine;

[CreateAssetMenu(fileName = "HealBehavior", menuName = "Items/Behaviors/Heal")]
public class HealBehavior : ItemBehaviorBase
{
    [SerializeField] private int _healAmount;

    public override void Use(ItemUseContext itemUseContext)
    {
        int healValue = Mathf.Max(0, _healAmount);

        if (_healAmount < 0)
            Debug.LogWarning($"[HealBehavior] Heal amount is less than zero: {_healAmount}");

        Player player = itemUseContext.Player;
        player.ModifyStatValue(StatType.Health, healValue);
    }
}
