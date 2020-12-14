using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomShoot : MonoBehaviour
{


    public GameObject bullt;

    public Transform targetr;

    public float speed;
    public CharacterController d;

    public Vector3Dataq jj;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        var velocity = d.velocity;
        
        transform.position += transform.forward * speed * Time.deltaTime;


        Instantiate(targetr, velocity, Quaternion.Euler(jj.value));
    }
}



