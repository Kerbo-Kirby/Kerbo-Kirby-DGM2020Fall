using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawn : MonoBehaviour
{
    // [SerializeField] private CharacterController con;


    public intData health;

    public Vector3Dataq spawnser, DeathSpawn;

    public GameObject spawnPoint, player;

    public intData healthMax;

    public void Start()
    {

        //  myLoc = GetComponent<Vector3>();

        transform.position = spawnser.value;

        healthMax.value = 5;


    }

    // Update is called once per frame
    void Update()
    {

        // transform.position = spawnser.value;

     
        if (health.value <= 0 )
        {


            transform.position = DeathSpawn.value ;
            //transform.position = spawnPoint.transform.position;


            health.value = 5;

        }
   //     else 
            
            

            






            //  healthMax.value = health.value;

            // if (player.transform.position == spawnPoint.transform.position)


            //spawnser.value =  spawnPoint.transform.position;
        




            //     if (health.value >= healthMax.value)

            //   {
            //      health .value = healthMax.value; 


            //   }





        }

    }

    

