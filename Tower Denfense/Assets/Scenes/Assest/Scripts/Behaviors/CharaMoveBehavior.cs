using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMoveBehavior : MonoBehaviour
{
    public float moveSpeed;
    

    public float dart;

    public float rotateSpeed;

    private Rigidbody rBody;

    private float yVec;

    // Update is called once per frame
    public void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
    
        float hAxis = Input.GetAxis("Horizontal") * rotateSpeed ;
        transform.Rotate( 0,hAxis, 0);

        float vAxis = Input.GetAxis("Vertical") * moveSpeed ;
       
        

        if (Input.GetKey(KeyCode.LeftShift))



            moveSpeed = 20;

        else

            moveSpeed = 5;


        if (Input.GetKey(KeyCode.CapsLock) && (moveSpeed <= dart))



            moveSpeed = dart;
        
        Vector3 movement = new Vector3(hAxis, 0 , vAxis)* moveSpeed* Time.deltaTime;
        
        
        rBody.MovePosition(transform.position + movement);
        
      
    }

}
