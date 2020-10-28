using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickcharacterBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        var otherTag = other.CompareTag("plat");
        
        
        
        if(otherTag)
        {
            transform.parent = other.transform;

        }


    }

    private void OnTriggerExit(Collider other)
    {


        transform.parent = null;
    }
}
