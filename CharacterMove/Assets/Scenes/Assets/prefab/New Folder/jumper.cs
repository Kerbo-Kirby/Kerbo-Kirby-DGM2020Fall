using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{

    public CharacterController con;
    
    
    
    
    public float gravity;
    
    public int jumpYeet = 5;
    public float jumpe = 10f;
    public  intData jumpHeightMax;
    
    private float yVar;

    public Vector3 playerVelo;
    
    
    

    // Update is called once per frame
    void Update()
    {
        playerVelo.y += gravity * Time.deltaTime;
        con.Move(playerVelo * Time.deltaTime);
        
        
        
        
        

        if (con.isGrounded && playerVelo.y < 0)

        {
            playerVelo.y = 0;

            jumpYeet = 0;


        }

        if (Input.GetButtonDown("Jump") && jumpYeet < jumpHeightMax.value)

        {

            playerVelo.y = jumpe;


            jumpYeet++;
            
            
        }


    }
}
