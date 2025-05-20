using UnityEngine;

[CreateAssetMenu(fileName = "TeleportBehavior", menuName = "Items/Behaviors/Teleport")]
public class TeleportBehavior : ItemBehaviorBase
{
    [SerializeField] private Transform _teleportPosition; //Improve

    public override void Use(ItemUseContext itemUseContext)
    {
        Transform playerTransform = itemUseContext.Player.transform;

        playerTransform.position = _teleportPosition.position;
    }
}
