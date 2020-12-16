using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;
using UnityEngine.Events;
public class shoot : MonoBehaviour
{

    public GameObject prefab;
   

    public void Instance()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            var location = transform.position;
            var newObj = Instantiate(prefab);
        }
    }
}

 



   

  
