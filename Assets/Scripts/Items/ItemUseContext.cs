using UnityEngine;

public class ItemUseContext
{
    private Player _player;
    private IDamageable _playerTarget;

    private object _customData;

    public Player Player => _player;
    public IDamageable PlayerTarget => _playerTarget;
    public object CustomData => _customData;

    public ItemUseContext(Player player, IDamageable playerTarget = null, object customData = null)
    {
        _player = player;
        _playerTarget = playerTarget;
        _customData = customData;
    }
}
