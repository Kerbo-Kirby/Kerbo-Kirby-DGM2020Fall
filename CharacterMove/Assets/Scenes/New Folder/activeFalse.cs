using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeFalse : MonoBehaviour
{
    public GameObject obj;


    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
  

    obj.SetActive(false);
    }


  
}
