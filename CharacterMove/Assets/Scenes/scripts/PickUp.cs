using System.Collections;
using System.Collections.Generic;
using UnityEngine;


  
    public class PickUp : MonoBehaviour
    {


        public int eggToAdd;
        
        
        protected void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                
                eggScoreManager.AddPoints(eggToAdd);
                
                Destroy(gameObject);
                
            }
            
        }
    }
