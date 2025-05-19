using UnityEngine;

[CreateAssetMenu(fileName = "FireDamageBehavior", menuName = "Items/Behaviors/FireDamage")]
public class FireDamageBehavior : ItemBehaviorBase
{
    [SerializeField] private readonly int _damage;

    public override void Use(ItemUseContext itemUseContext)
    {
        IDamageable target = itemUseContext.PlayerTarget;

        target.TakeDamage(_damage);
    }
}
