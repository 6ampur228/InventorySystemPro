using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _health = 100;
    [SerializeField] private int _mana = 50;
    [SerializeField] private int _fireDamageBaseValue = 5;

    private ModifiableStat _fireAttackDamage;

    public int FireAttackDamage => _fireAttackDamage.Value;

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
    public void BuffFireAttack(float multiplier, float duration)
    {
        StartCoroutine(ApplyTemporaryFireBuff(multiplier, duration));
    }

    private IEnumerator ApplyTemporaryFireBuff(float multiplier, float duration)
    {
        _fireAttackDamage.ApplyMultiplier(multiplier);
        yield return new WaitForSeconds(duration);
        _fireAttackDamage.ResetMultiplier();
    }

    public void InitModifiableStats()
    {
        _fireAttackDamage = new ModifiableStat(_fireDamageBaseValue);
    }

    private void TryDie()
    {
        //Логика смерти
    }
}
