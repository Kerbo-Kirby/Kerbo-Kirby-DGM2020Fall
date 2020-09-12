using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Health : MonoBehaviour
{

    public float waitTIme = 2f, amount;
        
        public IntData HealthMax, HealthCount;

        public Transform spawnPoint;
        private void Start()
        {

            HealthCount.value = HealthMax.value;
        }
        
    


        public IEnumerator OnTriggerEnter(Collider other)
        {
            
            
            
            
            

            yield return new WaitForSeconds(waitTIme);
            HealthCount.value -= HealthMax.value;
            gameObject.SetActive(false);
            
            
            

            transform.position = spawnPoint.position;
            HealthCount = HealthMax;
        }
        
}
