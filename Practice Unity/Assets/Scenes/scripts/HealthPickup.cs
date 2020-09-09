using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup


    public int currentHealth;


{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            PlayerHealth.
                Destroy(gameObject);
        }
    }
}