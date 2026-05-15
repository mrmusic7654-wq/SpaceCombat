using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    public WeaponData data;
    public abstract void Fire();
}