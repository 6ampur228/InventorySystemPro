using UnityEngine;

[CreateAssetMenu(fileName = "AttackBuffBehavior", menuName = "Items/Behaviors/AttackBuff")]
public class AttackBuffBehavior : ItemBehaviorBase
{
    [SerializeField] private float _duration;
    [SerializeField] private float _attackBuffMultiplier;

    public override void Use(ItemUseContext itemUseContext)
    {
        Player player = itemUseContext.Player;

        player.GetComponent<PlayerStats>()
              .BuffFireAttack(_attackBuffMultiplier, _duration);
    }
}
