using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    
   public Vector3 vOne,vTwo;
   public float speed = 2f;
   public float value;
   
   private void Update()
   {
   var direction = Vector3.Lerp(vOne,vTwo,value);
   
   transform.TransformVector(direction);
   } 
    
    
    
}
