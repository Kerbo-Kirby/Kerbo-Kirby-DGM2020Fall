using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed;
    
    private Rigidbody rBody;

    public float dart;
    public CharacterController con;

    public void Start()
    {
        con = GetComponent<CharacterController>(); 
    }


    void Update()
    {
        var hAxis = Input.GetAxis("Horizontal");

        var vAxis = Input.GetAxis("Vertical");




        if (Input.GetKey(KeyCode.LeftShift))



            moveSpeed = 15;

        else

            moveSpeed = 10;



        if (Input.GetKey(KeyCode.CapsLock) && (moveSpeed < dart))


            moveSpeed = dart;


       // movement = transform.TransformDirection(movement);
      ///  con.Move(movement * Time.deltaTime);

    

         Vector3 movement = new Vector3(hAxis, 0,vAxis) * moveSpeed * Time.deltaTime;
             
             con.Move(transform.position = movement);
                
            

        }
    }

