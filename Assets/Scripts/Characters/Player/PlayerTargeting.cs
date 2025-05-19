using UnityEngine;

public class PlayerTargeting : MonoBehaviour
{
    [SerializeField] private Enemy _target;

    public IDamageable Target => _target;
}
