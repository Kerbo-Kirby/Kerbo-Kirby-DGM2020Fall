using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locationChange : MonoBehaviour
{
   /// public Transform player;

    public Vector3Dataq locChange;

    public CharacterController player;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    public void update()
    {


        player.transform.position = locChange.value;
       player.enabled = true;
    }
 
}


