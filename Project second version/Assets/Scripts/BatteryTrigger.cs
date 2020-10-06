using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryTrigger : MonoBehaviour
{
    public int num;
    public int n = 0;
    public GameObject Door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.Translate(new Vector3(10, -10, 10));

            n++;

            if (n == num)
            {
                Destroy(Door);
            }

            Debug.Log(n);
        }
    }
}
