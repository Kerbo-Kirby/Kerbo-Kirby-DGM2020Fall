using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    public GameObject bullet;
    
   
    public Vector3Dataq bang;
    public CharacterController cont;
  
    //.///public vector3Data bang;


    public void instance ()
    {
// velocity of the rigid body


        var velocity = cont.velocity;

       transform.Translate(Vector3.forward * Time.deltaTime);
       
       //the instance calls it and the velocity is a vector 3 while the wyaternion is a rotation
       
        Instantiate(bullet, velocity, Quaternion.Euler(bang.value));

        
        
    }
}
