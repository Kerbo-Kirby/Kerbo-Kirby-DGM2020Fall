﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class collidetriger : MonoBehaviour
{

    public GameObject newobj;

    public GameObject obj;
    
    public Color big = Color.cyan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerStay(Collider other)
    {
        obj.SetActive(false);
     
        
print("now you dont see me");
    }

    private void OnTriggerExit(Collider other)
    {
        obj.SetActive(true);
        print("now you see me");
        Destroy(newobj);
    }


    void Update()
    {
        
    }
}
