using UnityEngine;

[RequireComponent(typeof(PlayerStats))]
[RequireComponent(typeof(PlayerInventory))]
public class Player : MonoBehaviour, IDamageable
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private PlayerInventory _playerInventory;

    private void OnValidate()
    {
        _playerStats ??= GetComponent<PlayerStats>();
        _playerInventory ??= GetComponent<PlayerInventory>();
    }

    public void ModifyStatValue(StatType statType, int value)
    {
        _playerStats.ModifyStatValue(statType, value);
    }

    public void UseSelectedItem()
    {
        ItemUseContext itemUseContext = new ItemUseContext(this);

        _playerInventory.UseItem(itemUseContext);
    }

    public void TakeDamage(int damage)
    {
        _playerStats.ModifyStatValue(StatType.Health, -damage);
    }
}
