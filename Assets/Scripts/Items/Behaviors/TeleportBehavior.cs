using UnityEngine;

[CreateAssetMenu(fileName = "TeleportBehavior", menuName = "Items/Behaviors/Teleport")]
public class TeleportBehavior : ItemBehaviorBase
{
    [SerializeField] private Vector3 _center = Vector3.zero;
    [SerializeField] private Vector3 _range = new Vector3(50, 0, 50);

    public override void Use(ItemUseContext itemUseContext)
    {
        Transform playerTransform = itemUseContext.Player.transform;

        Vector3 randomOffset = new Vector3(
            Random.Range(-_range.x, _range.x),
            Random.Range(-_range.y, _range.y),
            Random.Range(-_range.z, _range.z)
        );

        Vector3 targetPosition = _center + randomOffset;
        playerTransform.position = targetPosition;
    }
}
