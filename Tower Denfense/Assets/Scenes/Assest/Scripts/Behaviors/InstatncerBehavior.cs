﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatncerBehavior : MonoBehaviour
{




    public Transform prefab;
    public Vector3Data rotAim;

    public void Instance()
    {
        var location = transform.position;
        var newObj = Instantiate(prefab, location, Quaternion.Euler(rotAim.value));


        
    }
}

        
    
