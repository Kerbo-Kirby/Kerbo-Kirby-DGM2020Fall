using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthTrigger : MonoBehaviour
{


    public UnityEvent playerOwchy;
    
    
    
    
    
    
    
    private void OnTriggerEnter(Collider other)
    {
       
       
      playerOwchy.Invoke();
    
      
    }
}
