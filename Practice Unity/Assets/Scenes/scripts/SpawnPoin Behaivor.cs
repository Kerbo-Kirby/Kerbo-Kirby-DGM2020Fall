
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UIElements;

public class SpawnPointBehavior : MonoBehaviour
{

    public Vector3Data vData;


    public GameObject Player;


    //Set the vData from the position value on start


    public void Start()
    {



        vData.value = (transform.position);



        print("i need help");
    }

    private void OnTriggerEnter(Collider other)

    {
//  vData.value = (SpawnPointBehavior.vector3);




        

        vData.value = new Vector3(0,0,);

        print(" im here");


        


//set the location data of the player to the current spawnPo


    }
}




    
    














