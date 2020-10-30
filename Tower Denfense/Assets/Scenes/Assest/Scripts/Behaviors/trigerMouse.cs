using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class trigerMouse : MonoBehaviour
{

  public UnityEvent mouse;
    
    private void OnTriggerEnter(Collider other)
    {

        if (Input.GetKey(KeyCode.Q))

        {
            mouse.Invoke(  );
            
            
           
            print("test");
            
            
        }
    }
    
    
    
}
