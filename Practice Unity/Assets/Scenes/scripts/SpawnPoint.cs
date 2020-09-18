
using System;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnPoint : MonoBehaviour
{

    public Vector3Data vData;

   
    public GameObject Player;




    //Set the vData from the position value on start


    public void Start()
    {

        vData.value = (transform.position); 
       
        
    }

    public void OnTriggerEnter(Collider player)
    
    {
       vData.SetValueFromTransform(transform.position);
        
       new Vector3(0,0,0); 
        
        
    }


    //set the location data of the player to the current spawnPo
    
    
    

}












