using UnityEngine;

[CreateAssetMenu(fileName = "FireDamageBehavior", menuName = "Items/Behaviors/FireDamage")]
public class FireDamageBehavior : ItemBehaviorBase
{
    public override void Use(ItemUseContext itemUseContext)
    {
        //�� itemUseContext ����� ������ ������ � ������������ ������
        Debug.Log("fire!!");
    }
}
