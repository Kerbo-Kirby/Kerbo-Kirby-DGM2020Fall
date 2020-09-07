using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PickUp : MonoBehaviour
{
    public int points = 1;

    public int Add;
    
    
    
    public void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Score.Add(points);
            
            Destroy(gameObject);
        }


       
    }
}
        
        
    


   
        
     