using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "SpaceCombat/EnemyData")]
public class EnemyData : ScriptableObject
{
    public float health;
    public float speed;
    public float attackRange;
}