using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler Instance;
    private Dictionary<string, Queue<GameObject>> pool = new Dictionary<string, Queue<GameObject>>();

    private void Awake() => Instance = this;

    public GameObject GetFromPool(GameObject prefab, Vector3 pos, Quaternion rot)
    {
        if (!pool.ContainsKey(prefab.name)) pool[prefab.name] = new Queue<GameObject>();
        if (pool[prefab.name].Count > 0) {
            GameObject obj = pool[prefab.name].Dequeue();
            obj.transform.SetPositionAndRotation(pos, rot);
            obj.SetActive(true);
            return obj;
        }
        return Instantiate(prefab, pos, rot);
    }
}