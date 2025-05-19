using UnityEngine;

[CreateAssetMenu(fileName = "TeleportBehavior", menuName = "Items/Behaviors/Teleport")]
public class TeleportBehavior : ItemBehaviorBase
{
    [SerializeField] private Transform _teleportPosition;

    public override void Use(ItemUseContext itemUseContext)
    {
        //
    }
}
