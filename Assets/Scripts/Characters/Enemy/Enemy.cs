using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private Player _attackTargetPlayer;
    [SerializeField] private int _health = 100;
    [SerializeField] private int _attackDamage = 10;
    [SerializeField] private float _attackInterval = 1.5f;

    private IDamageable _attackTarget;
    private CancellationTokenSource _cts;
    private bool _isAttacking;

    private void Awake()
    {
        _attackTarget = _attackTargetPlayer;
    }

    private void Update()
    {
        if((_attackTarget == null && _isAttacking) || Input.GetKeyDown(KeyCode.R))
            StopAttack();

        if (Input.GetKeyDown(KeyCode.T) && !_isAttacking)
            if(_attackTarget != null)
                StartAttack();
    }

    private async void StartAttack()
    {
        _isAttacking = true;
        _cts = new CancellationTokenSource();

        try
        {
            while (!_cts.Token.IsCancellationRequested)
            {
                _attackTarget.TakeDamage(_attackDamage);
                await Task.Delay(TimeSpan.FromSeconds(_attackInterval), _cts.Token);
            }
        }
        catch (TaskCanceledException) { }
    }

    private void StopAttack()
    {
        _cts?.Cancel();
        _isAttacking = false;
    } 

    public void TakeDamage(int damage)
    {
        _health -= damage;

        TryDie();
    }

    private void TryDie()
    {
        if (_health <= 0)
            Destroy(gameObject);
    }
}
