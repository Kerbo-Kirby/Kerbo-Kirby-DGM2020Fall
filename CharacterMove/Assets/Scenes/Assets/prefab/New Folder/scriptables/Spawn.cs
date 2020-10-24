using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
   // [SerializeField] private CharacterController con;
    
    
    public intData health;

    public Vector3Dataq spawnser;

    public GameObject spawnPoint, player;

    public intData healthMax;

    
    public void Start()
    {


       
    }

    // Update is called once per frame
        void Update()
        {
            healthMax.value = health.value;
           

            if (health.value <= 0)
            {
       
               

               
               
              ///  player.transform.position = spawnPoint.transform.position;
                
              ///  healthMax.value = health.value;

               // if (player.transform.position == spawnPoint.transform.position)
               // {
                 
                    healthMax.value = health.value;

              //  }


                
                
                
                
                
                
                
                
                
               // / //spawnser.value =  spawnPoint.transform.position;
                ///  var location = transform.position;

                
                
                

                //     if (health.value >= healthMax.value)

                //   {
                //      health .value = healthMax.value; 


                //   }





            }

        }
    }

