using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Bulletforce : MonoBehaviour
{
    private Rigidbody rBody;
    public float force = 30f;
    public Vector3Dataq pew;
   public void Start()
    {
        
        if(Input.GetKey(KeyCode.Mouse0))
        
        rBody = GetComponent<Rigidbody>();

  
      
        //var forceDirection = new Vector3(force, 0, 0);
        rBody.AddRelativeForce(pew.value* force );
        
      


    }
}
