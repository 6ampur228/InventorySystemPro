using UnityEngine;

[RequireComponent(typeof(PlayerStats))]
[RequireComponent(typeof(PlayerInventory))]
[RequireComponent(typeof(PlayerTargeting))]
[RequireComponent(typeof(BuffManager))]
public class Player : MonoBehaviour, IDamageable
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private PlayerInventory _playerInventory;
    [SerializeField] private PlayerTargeting _playerTargeting;
    [SerializeField] private BuffManager _buffManager;

    private void OnValidate()
    {
        _playerStats ??= GetComponent<PlayerStats>();
        _playerInventory ??= GetComponent<PlayerInventory>();
        _playerTargeting ??= GetComponent<PlayerTargeting>();
        _buffManager ??= GetComponent<BuffManager>();
    }

    private void Awake()
    {
        _buffManager.Init(_playerStats);
    }

    public void ModifyStatValue(StatType statType, int value)
    {
        _playerStats.ModifyStatValue(statType, value);
    }

    public void UseSelectedItem()
    {
        ItemUseContext context = new ItemUseContext.Builder()
            .SetPlayer(this)
            .SetTarget(_playerTargeting.Target)
            .Build();

        _playerInventory.UseItem(context);
    }

    public void TakeDamage(int damage)
    {
        _playerStats.ModifyStatValue(StatType.Health, -damage);
    }
}
