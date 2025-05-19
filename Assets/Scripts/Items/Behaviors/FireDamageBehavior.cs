using UnityEngine;

[CreateAssetMenu(fileName = "FireDamageBehavior", menuName = "Items/Behaviors/FireDamage")]
public class FireDamageBehavior : ItemBehaviorBase
{
    public override void Use(ItemUseContext itemUseContext)
    {
        IDamageable target = itemUseContext.PlayerTarget;

        int fireDamage = itemUseContext.Player
            .GetComponent<PlayerStats>()
            .ModifiableStats[ModifiableStatType.FireAttackDamage]
            .Value;

        target.TakeDamage(fireDamage);
    }
}
