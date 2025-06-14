using UnityEngine;

[CreateAssetMenu(fileName = "TeleportBehavior", menuName = "Items/Behaviors/Teleport")]
public class TeleportBehavior : ItemBehaviorBase
{
    [SerializeField] private Vector3 _target;

    public override void Use(ItemUseContext itemUseContext)
    {
        //Из itemUseContext брать нужный объект и реализовывть логику
        Debug.Log("+random position");
    }
}
