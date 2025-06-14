using UnityEngine;

[CreateAssetMenu(fileName = "TeleportBehavior", menuName = "Items/Behaviors/Teleport")]
public class TeleportBehavior : ItemBehaviorBase
{
    [SerializeField] private Vector3 _target;

    public override void Use(ItemUseContext itemUseContext)
    {
        //�� itemUseContext ����� ������ ������ � ������������ ������
        Debug.Log("+random position");
    }
}
