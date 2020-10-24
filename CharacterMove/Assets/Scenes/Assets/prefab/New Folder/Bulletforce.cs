using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletforce : MonoBehaviour
{
    private Rigidbody rBody;
    public float force = 30f;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        var forceDirection = new Vector3(force, 0, 0);
        rBody.AddRelativeForce(forceDirection);
        
        gameObject.SetActive((true));


        new WaitForSeconds(1);
   
    }
}
