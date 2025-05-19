using System.Collections;
using UnityEngine;

public class BuffManager : MonoBehaviour
{
    private PlayerStats _playerStats;

    public void Init(PlayerStats playerStats)
    {
        _playerStats = playerStats;
    }

    public void ApplyTemporaryBuff(ModifiableStatType modifiableStatType, float multiplier, float duration)
    {
        StartCoroutine(BuffCoroutine(modifiableStatType, multiplier, duration));
    }

    private IEnumerator BuffCoroutine(ModifiableStatType modifiableStatType, float multiplier, float duration)
    {
        var stat = _playerStats.ModifiableStats[modifiableStatType];

        stat.ApplyMultiplier(multiplier);
        yield return new WaitForSeconds(duration);
        stat.ResetMultiplier();
    }
}
