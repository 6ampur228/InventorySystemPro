using UnityEngine;

[CreateAssetMenu(fileName = "RestoreManaBehavior", menuName = "Items/Behaviors/RestoreMana")]
public class RestoreManaBehavior : ItemBehaviorBase
{
    [SerializeField] private int _restoreManaAmount;

    public override void Use(ItemUseContext itemUseContext)
    {
        //�� itemUseContext ����� ������ ������ � ������������ ������
        Debug.Log("+mana");
    }
}
