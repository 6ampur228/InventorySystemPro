using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private int _health;
    private int _mana;

    public void ModifyStatValue(StatType statType, int value)
    {
        switch(statType)
        {
            case StatType.Health:
                _health += value;
                break;
            case StatType.Mana:
                _mana += value;
                break;
        }
    }
}
