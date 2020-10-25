using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Vector3Dataq : ScriptableObject
{

    
    
    
    
    public Vector3 value;
    
    
    
    

    public void SetValueFromVector3(Vector3 obj)
    {
        value = obj;
    }

    public void SetValueFromPosition(Transform obj)
    {
        value = obj.position;
    }
}