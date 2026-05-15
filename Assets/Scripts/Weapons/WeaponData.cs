using UnityEngine;

[CreateAssetMenu(fileName = "NewWeapon", menuName = "SpaceCombat/WeaponData")]
public class WeaponData : ScriptableObject
{
    public string weaponName;
    public float fireRate;
    public float damage;
    public GameObject projectilePrefab;
}