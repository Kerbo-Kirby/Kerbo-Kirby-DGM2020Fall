using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class LookAt : MonoBehaviour
{
    

    public void OnLook(Vector3Data obj)

    {
        /// "turret"///
        
        transform.LookAt(obj.value);
        var transformRotation = transform.eulerAngles ;
        transformRotation.x = 0;
        transformRotation.y -= 90;
        transform.rotation = Quaternion.Euler(transformRotation);
        
    }

}




