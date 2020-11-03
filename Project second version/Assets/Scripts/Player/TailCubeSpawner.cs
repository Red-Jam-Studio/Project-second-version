using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailCubeSpawner : MonoBehaviour
{
    bool hadBeenSpawned = false;
    public GameObject player;

    private void Start()
    {
        StartCoroutine(TailCubeWait());
    }
    void Update()
    {
        if ((transform.position.x % 2 == 0) && (transform.position.z % 2 == 0))
        {
            if (!hadBeenSpawned)
            {
                hadBeenSpawned = true;

                ObjectPooler.Instance.SpawnFromPool("TailCube", player.transform.position, Quaternion.identity);
            }
        }
        else
        {
            hadBeenSpawned = false;
        }
    }

    IEnumerator TailCubeWait()
    {
        yield return new WaitForSeconds(1);
    }
}
