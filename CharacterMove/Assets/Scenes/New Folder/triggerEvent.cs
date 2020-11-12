using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class triggerEvent : MonoBehaviour
{


    public UnityEvent trig;
    
    
    
    
    
    
    
    private void OnTriggerEnter(Collider other)
    {
       
       
      trig.Invoke();
    
      
    }
}
