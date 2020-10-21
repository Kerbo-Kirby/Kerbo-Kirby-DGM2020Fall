using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class StringTextdata : ScriptableObject
{

    private string returnValue;
    
    
    public List<string> dialog;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
  public void SetTextuiToValue (Text obj)
  {
      obj.text = returnValue;
  }
}
