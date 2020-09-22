using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    

    

    public GameObject enemy;

    public float spawnTime = 2f;

    public IntData enemyHealthMax, enemyHealthCount;

    public Transform enemySpawnPoint;

    private void Start()
    {

        enemyHealthCount.value = enemyHealthMax.value;
        enemy = new GameObject();

    }




    private IEnumerator OnTriggerEnter(Collider other)
    {

        yield return new WaitForSeconds(spawnTime);
        enemyHealthCount.value -= enemyHealthMax.value;
        enemy.SetActive(false);



        var location = enemySpawnPoint.position;
        enemyHealthCount = enemyHealthMax;
        enemy.SetActive(true);
        yield return null;


    }
}


