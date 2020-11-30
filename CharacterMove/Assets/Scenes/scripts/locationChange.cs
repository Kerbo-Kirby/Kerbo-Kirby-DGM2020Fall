using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locationChange : MonoBehaviour
{
    public Transform player;

    public Vector3Dataq locChange;
    
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    public void OnTriggerEnter(Collider player)
    {
      
            player.transform.position = locChange.value;
           
    }
 
}


