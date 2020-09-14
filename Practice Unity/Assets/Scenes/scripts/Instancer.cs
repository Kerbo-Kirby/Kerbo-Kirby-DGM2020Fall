using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    public GameObject prefab;
    
    
    
    
   public void Instance()
   {
       
       
       
       var location = transform.position;
       var RotationDirection = new Vector3(0f,45,2f);
       
       Instantiate(prefab,location, Quaternion.Euler(RotationDirection));
      
      
      
      
   }
}
