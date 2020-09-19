
using System;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UIElements;

public class SpawnPoint : MonoBehaviour
{

    public Vector3Data vData;


    public GameObject Player;


    //Set the vData from the position value on start


    public void Start()
    {
        
        
        
       // vData.value = (transform.position); 

        vData.value = GetComponent<Vector3>();
        
        print("i need help");
    }

    public void OnTriggerEnter(Collider other)
    
    {
        
        
        
     //  vData.SetValueFromTransform(transform.position);
        
        var location = transform.position;
        
        
        
        

        //gameObject.SetActive(true);
        
        
        print(" im here");
        
    }


    //set the location data of the player to the current spawnPo
    
    
    

}












