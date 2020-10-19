using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperWin : MonoBehaviour
{
    public int num;
    public GameObject Door;
    int n = 0;
    public void Counter()
    {
        n++;
        if (n == num)
        {
            Destroy(Door);
        }

        Debug.Log(n);
    }
}
