using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform prefab;


    public Vector3Dataq ban;
    public CharacterController con;

    public void Start()
    {
        
    }


    public void instancevv()
    {
        /// velocity of the rigid body
        var velocity = con.velocity;

        transform.Translate(ban.value* Time.deltaTime);

        //the instance calls it and the velocity is a vector 3 while the wyaternion is a rotation

        Instantiate(prefab, velocity, Quaternion.Euler(ban.value));



    }
}
