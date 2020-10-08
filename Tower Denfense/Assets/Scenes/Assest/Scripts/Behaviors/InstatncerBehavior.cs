using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatncerBehavior : MonoBehaviour
{




    public Transform prefab;
    public Vector3Data rotAim;

    public void Instance()
    {

        var location = transform.position;
        var newObj = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}

        
    
