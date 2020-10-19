using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryTrigger : MonoBehaviour
{
    public GameObject Helper;

    public HelperWin helperWin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.Translate(new Vector3(10, -10, 10));
            helperWin = Helper.GetComponent<HelperWin>();
            helperWin.Counter();
        }
    }
}
