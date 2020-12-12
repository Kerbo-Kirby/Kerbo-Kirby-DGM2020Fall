using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class animationtrig : MonoBehaviour

{



    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))

            GetComponent<Animator>().Play("disapea");



    }
}
    
    
    

