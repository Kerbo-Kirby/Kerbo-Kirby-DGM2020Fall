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




    private IEnumerator OnTriggerEnter(Collider other)
    {

        
        HealthCount.value -= HealthMax.value;
        yield return new WaitForSeconds(waitTIme);
        
        if (HealthCount.value <= 0)
        {
            gameObject.SetActive(false);
            transform.position = spawnPoint.position;
            HealthCount = HealthMax;
            
            gameObject.SetActive((true));
        }

        
         

        // if (HealthCount = HealthMax)
        //  {
        //   yield return null ;

        //   StopAllCoroutines();

        // }


    }
}
