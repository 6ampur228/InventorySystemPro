using UnityEngine;
using System.Collections.Generic;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _health = 100;
    [SerializeField] private int _mana = 50;
    [SerializeField] private int _fireDamageBaseValue = 5;

    public Dictionary<ModifiableStatType, ModifiableStat> ModifiableStats { get; private set; }

    private void Awake()
    {
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
    }

    private void TryDie()
    {
        //Логика смерти
    }
}
