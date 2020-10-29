using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    void FixedUpdate()
    {
        ObjectPooler.Instance.SpawnFromPool("Cube", transform.position, Quaternion.identity);
    }
}
