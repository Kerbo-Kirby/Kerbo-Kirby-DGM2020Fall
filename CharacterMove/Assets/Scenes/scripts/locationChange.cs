using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class locationChange : MonoBehaviour
{
    /// public Transform player;

    public Vector3Dataq locChange;

    public GameObject player;


    void Start()
    {


    }

    public void OnTriggerEnter(Collider other)
    {
       
        {
            
            
          locChange.value =  gameObject.transform.position;
            
     
            
            Debug.Log("im ober here");
        }
       // else 
           // Debug.Log("what happended?");
    }
}

