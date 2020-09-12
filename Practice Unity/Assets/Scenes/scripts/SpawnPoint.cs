using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnPoint : MonoBehaviour
{

    public Vector3Data vData;
        
        public Vector3 Position;


        public GameObject Player;
        
        
    //Set the vData from the position value on start


    public void Start()
    {
        Position = GetComponent<Vector3>();
        
        

    }


    public void OnTriggerEnter(Collider other)
    {
        //set the location data of the player to the current spawnPo
        //
        Vector3 Player = new Vector3(0,0,0);



    }
}










