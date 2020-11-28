using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject prefab;


    public Vector3Dataq ban;
    public CharacterController con;

 


    public void instance()
    {
        /// velocity of the rigid body
        var velocity = con.velocity;

        // transform.Translate(Vector3.forward * Time.deltaTime);

        //the instance calls it and the velocity is a vector 3 while the wyaternion is a rotation

        Instantiate(prefab, velocity, Quaternion.Euler(ban.value));



    }
}
