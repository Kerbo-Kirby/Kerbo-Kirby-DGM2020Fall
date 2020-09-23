using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    

    

   

    public float spawnTime = 2f;

    public IntData enemyHealthMax, enemyHealthCount;

    public Transform enemySpawnPoint;

    private void Start()
    {

        enemyHealthCount.value = enemyHealthMax.value;
       

    }




    private IEnumerator OnTriggerEnter(Collider other)
    {

        yield return new WaitForSeconds(spawnTime);
        enemyHealthCount.value -= enemyHealthMax.value;
        gameObject.SetActive(false);



        var location = enemySpawnPoint.position;
        enemyHealthCount = enemyHealthMax;
        gameObject.SetActive(true);
        


    }
}


