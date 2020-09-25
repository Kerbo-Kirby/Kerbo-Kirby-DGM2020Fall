using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class PickUpBehavior : MonoBehaviour
{
    public string pickupName;
    public string pickupType;
    public int pointsToAdd;




    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Point.AddPoints(pointsToAdd);
            Destroy(gameObject);
        }
    }
}
