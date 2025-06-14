using UnityEngine;

[CreateAssetMenu(fileName = "FireDamageBehavior", menuName = "Items/Behaviors/FireDamage")]
public class FireDamageBehavior : ItemBehaviorBase
{
    public override void Use(ItemUseContext itemUseContext)
    {
        //Из itemUseContext брать нужный объект и реализовывть логику
        Debug.Log("fire!!");
    }
}
