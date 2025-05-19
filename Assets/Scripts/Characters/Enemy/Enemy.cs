using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    private int _health;

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
}
