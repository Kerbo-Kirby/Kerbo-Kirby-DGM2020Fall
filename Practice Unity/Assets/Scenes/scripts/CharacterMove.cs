using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMove : MonoBehaviour

{
    private CharacterController controller;
    private Vector3 movement;
    public float gravity = 1.5f;
    public float moveSpeed = 3f;
    public float jumpForce = 10f;

    // public int jumpCountMax;

    // public float rotateSpeed = 3f;

    public bool canJump; 
    
    public Vector3 rotateMovement;


    void Start()
    {


        controller = GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateMovement);
        movement.x = moveSpeed;


        if (Input.GetKey(KeyCode.D))
        {
            movement.x *= -moveSpeed;
        }


        if (Input.GetButtonDown("Jump"))
        {
            movement.y = jumpForce;
        }

        if (controller.isGrounded)
        {
            movement.y = 0;
        }

        else
        {
            movement.y -= gravity;
        }
        
        if (Input.GetKey(KeyCode.Space))
            
        {
            movement.y *= -jumpForce;
        }





        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}