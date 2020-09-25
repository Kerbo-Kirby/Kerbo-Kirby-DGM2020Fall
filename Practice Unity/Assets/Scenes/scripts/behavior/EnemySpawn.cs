using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    
    public Vector3Data vecData;
    
    // Start is called before the first frame update
    void Start()
    {
        vecData.value = GetComponent<Vector3>();
        print("i am curenttly here");
    }

   
        private void OnTriggerEnter(Collider other)
    
        {
            
        
            var location = transform.position;
        
        
        
       
        
        
            print(" over here!");

    }
}
