using UnityEngine;

[CreateAssetMenu(fileName = "AttackBuffBehavior", menuName = "Items/Behaviors/AttackBuff")]
public class AttackBuffBehavior : ItemBehaviorBase
{
    [SerializeField] private float _duration;
    [SerializeField] private float _attackBuffMultiplier;

    public override void Use(ItemUseContext itemUseContext)
    {
        //player.BuffAttack(_attackBuffMultiplier, _duration);
    }
}
