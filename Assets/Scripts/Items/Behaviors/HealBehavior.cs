using UnityEngine;

[CreateAssetMenu(fileName = "HealBehavior", menuName = "Items/Behaviors/Heal")]
public class HealBehavior : ItemBehaviorBase
{
    [SerializeField] private int _healAmount;

    public override void Use(/*ItemUseContext itemUseContext*/)
    {
        //Из itemUseContext брать нужный объект и реализовывть логику
        Debug.Log("+hp");
    }
}
