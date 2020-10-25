using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonBehavior : MonoBehaviour
{

// i define where i want it to pop up and what i want to pop up.
    
    
    public GameObject summonItem;


    public Vector3Dataq SummonLocation;

    
    // Start is called before the first frame update
    void Start()
    {
        /// i dont want the player to see it at first so i want to hide it
        summonItem.SetActive(false);
      
    }

    //  on enter it will activate and be called  on a location. so if you lose it you can summon it back!
    private void OnTriggerEnter(Collider other)
    {
        summonItem.SetActive(true);
        
        summonItem.transform. position = SummonLocation.value;

    }
    

       
       
  
  
  
  
  
  

    }

