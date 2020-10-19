using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public GameObject PoolCube;

    void FixedUpdate()
    {
        Instantiate(PoolCube, transform.position, Quaternion.identity);
    }
}
