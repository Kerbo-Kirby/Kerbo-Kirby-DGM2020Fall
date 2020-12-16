using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    public float speed;

    public Transform player;


    public void OnTriggerEnter(Collider other)
    {
        transform.LookAt(player);
    }


  
}

