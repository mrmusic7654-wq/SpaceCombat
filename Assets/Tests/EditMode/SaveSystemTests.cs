using NUnit.Framework;
using UnityEngine;

public class SaveSystemTests
{
    [Test]
    public void TestSaveDataSerialization()
    {
        PlayerSaveData data = new PlayerSaveData { health = 100, score = 500 };
        string json = JsonUtility.ToJson(data);
        PlayerSaveData loaded = JsonUtility.FromJson<PlayerSaveData>(json);
        Assert.AreEqual(100, loaded.health);
        Assert.AreEqual(500, loaded.score);
    }
}