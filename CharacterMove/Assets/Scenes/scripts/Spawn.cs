using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawn : MonoBehaviour
{

    public CharacterController controller;

    public intData health,maxhealth;

    public Transform deathSpawn;

  //  public GameObject player;

   public healthBar healthslider; 
    public void Start()
    {
        
        controller = GetComponent<CharacterController>();
     healthslider.MaxSlide(maxhealth.value);
     
     
    }

    public void Update()
    {
        healthslider.BarHealth(health.value);
        if (health.value <= 0)
        {

            transform.position = deathSpawn.position;
            transform.rotation = deathSpawn.rotation;
            health.value = 5;

            controller.enabled = true;



        }







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





        

    

    

