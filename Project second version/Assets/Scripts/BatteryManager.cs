using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryManager : MonoBehaviour
{
    public GameObject Battery;
    public GameObject spawnA;
    public GameObject spawnB;
    public GameObject spawnC;
    public Vector3 Pos1;
    public Vector3 Pos2;
    public Vector3 Pos3;

    void Start()
    {
        spawnA = GameObject.Instantiate(Battery, Pos1, Quaternion.identity);
        spawnB = GameObject.Instantiate(Battery, Pos2, Quaternion.identity);
        spawnC = GameObject.Instantiate(Battery, Pos3, Quaternion.identity);
    }

    void Update()
    {
        
    }
}
