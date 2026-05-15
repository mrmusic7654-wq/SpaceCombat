using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    public EnemyData data;
    public abstract void TakeDamage(float amount);
}