using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawn : MonoBehaviour
{
    // [SerializeField] private CharacterController con;
    public CharacterController controller;

    public intData health;

    public Vector3Dataq DeathSpawn;
    
    public GameObject player;
  
  
    public void Start()
    {

       // controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

     


        if (health.value <= 0)
        {
            
            player.transform.position = DeathSpawn.value;


            health.value = 2;
            
            controller.enabled = true;
            
            

        }
      

        




    }
        
        
    // DeathSpawn.value = GetComponent<Vector3>();
   
   //     else 
            
            
   // transform.position = DeathSpawn.value;
   //transform.position = spawnPoint.transform.position;
            






            //  healthMax.value = health.value;

            // if (player.transform.position == spawnPoint.transform.position)


            //spawnser.value =  spawnPoint.transform.position;
        




            //     if (health.value >= healthMax.value)

            //   {
            //      health .value = healthMax.value; 


            //   }





        }

    

    

