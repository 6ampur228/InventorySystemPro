using UnityEngine;

[RequireComponent(typeof(PlayerStats))]
[RequireComponent(typeof(PlayerInventory))]
[RequireComponent(typeof(PlayerTargeting))]
public class Player : MonoBehaviour, IDamageable
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private PlayerInventory _playerInventory;
    [SerializeField] private PlayerTargeting _playerTargeting;

    private void OnValidate()
    {
        _playerStats ??= GetComponent<PlayerStats>();
        _playerInventory ??= GetComponent<PlayerInventory>();
        _playerTargeting ??= GetComponent<PlayerTargeting>();
    }

    private void Awake()
    {
        _playerStats.InitModifiableStats();
    }

    public void ModifyStatValue(StatType statType, int value)
    {
        _playerStats.ModifyStatValue(statType, value);
    }

    public void UseSelectedItem()
    {
        ItemUseContext itemUseContext = new ItemUseContext(this, _playerTargeting.Target);

        _playerInventory.UseItem(itemUseContext);
    }

    public void TakeDamage(int damage)
    {
        _playerStats.ModifyStatValue(StatType.Health, -damage);
    }
}
