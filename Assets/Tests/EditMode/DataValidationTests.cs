using NUnit.Framework;
using UnityEngine;

public class DataValidationTests
{
    [Test]
    public void TestWeaponDataIntegrity()
    {
        WeaponData data = ScriptableObject.CreateInstance<WeaponData>();
        data.damage = 10;
        Assert.GreaterOrEqual(data.damage, 0);
    }
}