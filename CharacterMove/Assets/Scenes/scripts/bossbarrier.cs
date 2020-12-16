using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossbarrier : MonoBehaviour
{
    public GameObject wall;
    void Start()
    {
       wall.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        wall.SetActive(true);
    }
    
    

  
}
