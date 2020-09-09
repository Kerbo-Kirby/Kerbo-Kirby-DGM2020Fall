using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float waitTIme = 2f;
        
        public FloatData HealthMax, HealthCount, powerCount;


        private void Start()
        {

            HealthCount.value = HealthMax.value;
        }

        public IEnumerator OnTriggerEnter(Collider other)
        {
            HealthCount.value = powerCount.value;
            
            yield return new WaitForSeconds(waitTIme);
            HealthCount.value = HealthMax.value;
            gameObject.SetActive(false);
        }
}
