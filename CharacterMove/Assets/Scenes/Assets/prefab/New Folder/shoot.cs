using System.Collections;
using System.Collections.Generic;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject prefab;


    public Vector3Dataq bang;


        //.///public vector3Data bang;
    
  
    public void Instance()
    { 
            
        var location = transform.position;
            
            
        Instantiate(prefab,location , Quaternion.Euler(bang.value));


    }
}
