using UnityEngine;

public class ModifiableStat
{
    private int _baseValue;
    private float _multiplier = 1f;

    public ModifiableStat(int baseValue)
    {
        _baseValue = baseValue;
    }

    public int Value => Mathf.RoundToInt(_baseValue * _multiplier);

    public void ApplyMultiplier(float multiplier) => _multiplier *= multiplier;
    public void ResetMultiplier() => _multiplier = 1f;
}
