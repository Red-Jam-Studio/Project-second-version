using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    #region Singleton
    public static ObjectPooler Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    public List<Pool> poolList;
    public Dictionary<string, Queue<GameObject>> poolDictionary;


    void Start ()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pl in poolList)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pl.size; i++)
            {
                GameObject obj = Instantiate(pl.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pl.tag, objectPool);
        }
    }

    public GameObject SpawnFromPool (string tag, Vector3 pos, Quaternion rotat)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool with tag " + tag + " doesn't exist");
            return null;
        }


        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = pos;
        objectToSpawn.transform.rotation = rotat;

        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }
}
