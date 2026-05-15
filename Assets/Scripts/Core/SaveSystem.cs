using UnityEngine;
using System.IO;

public static class SaveSystem
{
    public static void Save(PlayerSaveData data) => File.WriteAllText(Application.persistentDataPath + "/save.json", JsonUtility.ToJson(data));
    public static PlayerSaveData Load() => JsonUtility.FromJson<PlayerSaveData>(File.ReadAllText(Application.persistentDataPath + "/save.json"));
}