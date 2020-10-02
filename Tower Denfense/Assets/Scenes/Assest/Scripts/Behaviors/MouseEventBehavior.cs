using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

public class MouseEventBehavior : MonoBehaviour
{
    
    
    
    
    
    public UnityEvent mouseDownEvent;

    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();

        print("click");
    }
     
    
}
