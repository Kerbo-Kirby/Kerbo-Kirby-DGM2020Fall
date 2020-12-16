using System;
using System.Collections;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    public GameObject prefab;
   
    
    
    
    public void Instance()
    {
        var location = transform.position;
        var newObj = Instantiate(prefab);
    }
}