using UnityEngine;

[CreateAssetMenu(fileName = "FireDamageBuffBehavior", menuName = "Items/Behaviors/FireDamageBuff")]
public class FireDamageBuffBehavior : ItemBehaviorBase
{
    [SerializeField] private float _duration;
    [SerializeField] private float _buffMultiplier;

    public override void Use(/*ItemUseContext itemUseContext*/)
    {
        //Из itemUseContext брать нужный объект и реализовывть логику
        Debug.Log("+buff");
    }
}
