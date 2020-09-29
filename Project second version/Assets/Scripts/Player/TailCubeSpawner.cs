using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailCubeSpawner : MonoBehaviour
{
    bool hadBeenSpawned = false;
    public GameObject tailCube;

    void Update()
    {
        if ((transform.position.x % 2 == 0) && (transform.position.z % 2 == 0))
        {
            if (!hadBeenSpawned)
            {
                hadBeenSpawned = true;
                Instantiate(tailCube, transform.position, Quaternion.identity);
            }
        }
        else
        {
            hadBeenSpawned = false;
        }
    }
}
