using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMove : MonoBehaviour
{

    public float moveSpeed = 5f, gravity = 1.5f, rotateSpeed = 15f, jumpForce = 1f;
    private Vector3 movement;
    private CharacterController _controller;

    private float yVar;
    
    public int jumpCountMax = 2;

    private int jumpCount;
    
    
    
    // Start is called before the first frame update
    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
   private void Update()
   {
       var vInput = Input.GetAxis("Vertical")*moveSpeed;
        movement.Set(vInput,yVar,0);

        var  hInput = Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeed;
        transform.Rotate( 0,hInput, 0);

       
        
        
        yVar += gravity * Time.deltaTime;

        if (_controller.isGrounded && movement.y < 0)
        {
            
            yVar = -1f;
            jumpCount = 0;
        }
           
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax    )
        {
            print(jumpCount);
            yVar = jumpForce;

            jumpCount++;
        }

      
        
        _controller.Move(movement * Time.deltaTime);

        //ovement = transform.TransformDirection(movement);


   }
}
