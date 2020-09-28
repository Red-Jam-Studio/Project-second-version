using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseClick : MonoBehaviour
{
    public GameObject Door;

    void OnMouseDown()
    {
        Destroy(gameObject);

        GameObject go = GameObject.Find("battery(Clone)");
        if (go == null)
        {
            Destroy(Door);
        }
    }


    void Start()
    {

    }

    void Update()
    {
        
    }
}
