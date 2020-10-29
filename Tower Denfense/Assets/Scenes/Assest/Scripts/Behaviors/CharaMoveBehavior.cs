using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(CharacterController))]
public class CharaMoveBehavior : MonoBehaviour
{


   
    public float moveSpeed;

    private Rigidbody rBody;

    public float dart;
    public CharacterController con;

    private float gravity = -10f;

    private Vector3 plallyerY;



    public void Start()
    {
        con = GetComponent<CharacterController>();

rBody = GetComponent<Rigidbody>();


    }


    void Update()
    {

        plallyerY.y += gravity * Time.deltaTime;
        
        
        
        
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



        Vector3 movement = new Vector3(hAxis, 0, vAxis) * moveSpeed * Time.deltaTime;

        rBody.MovePosition(transform.position + movement);
    }
}


