using UnityEngine;

[CreateAssetMenu(fileName = "HealBehavior", menuName = "Items/Behaviors/Heal")]
public class HealBehavior : ItemBehaviorBase
{
    [SerializeField] private int _healAmount;

    public override void Use(/*ItemUseContext itemUseContext*/)
    {
        //�� itemUseContext ����� ������ ������ � ������������ ������
        Debug.Log("+hp");
    }
}
