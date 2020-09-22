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
    }

   
        private void OnTriggerEnter(Collider other)
    
        {
            
        
            var location = transform.position;
        
        
        
        

            //gameObject.SetActive(true);
        
        
            print(" im here");

    }
}
