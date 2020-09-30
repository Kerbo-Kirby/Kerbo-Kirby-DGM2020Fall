using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonLerp : MonoBehaviour
{

    public Vector3 left,up;

    public float value = 0.5f;

    // Update is called once per frame
    private void Update()
    {
        
        
        
    transform.position = Vector3.Lerp(left,up,value);
    
   
    
     value += 0.5f *  Time.deltaTime;
transform.Translate(2,0,2);
     
    }
}
