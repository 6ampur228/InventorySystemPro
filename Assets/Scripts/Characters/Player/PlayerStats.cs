using UnityEngine;
using System.Collections.Generic;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _maxMana = 50;
    [SerializeField] private int _fireDamageBaseValue = 5;

    private int _health;
    private int _mana;

    public Dictionary<ModifiableStatType, ModifiableStat> ModifiableStats { get; private set; }

    private void Awake()
    {
        _health = _maxHealth;
        _mana = _maxMana;

        ModifiableStats = new Dictionary<ModifiableStatType, ModifiableStat>
        {
            { ModifiableStatType.FireAttackDamage, new ModifiableStat(_fireDamageBaseValue) }
        };
    }

    public void ModifyStatValue(StatType statType, int value)
    {
        switch(statType)
        {
            case StatType.Health:
                _health += value;
                TryDie();
                break;
            case StatType.Mana:
                _mana += value;
                break;
        }

        _mana = ClampStatValue(_mana, _maxMana);
        _health = ClampStatValue(_health, _maxHealth);
    }
    private int ClampStatValue(int value, int max)
    {
        return Mathf.Min(value, max);
    }

    private void TryDie()
    {
        //Логика смерти
    }
}
