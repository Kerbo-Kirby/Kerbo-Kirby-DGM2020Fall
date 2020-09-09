using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBoundary : MonoBehaviour
{
    public GameObject player;
    

    public void OnTriggerEnter(Collider other)
    {
        Destroy(player);
    }
    
    
    
    
    
    
    
    
    
    
    
    
}
