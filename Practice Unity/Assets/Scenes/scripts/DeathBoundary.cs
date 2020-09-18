using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBoundary : MonoBehaviour
{

    public GameObject player; 
    public float fallOut = 2f; 
 
     
    public IEnumerator OnTriggerEnter(Collider player) 
    { 
        
             
        yield return new WaitForSeconds(fallOut); 
         
        gameObject.SetActive(false); 
    }  
    
    
    
}
