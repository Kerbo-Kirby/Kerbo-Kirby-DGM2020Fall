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
    
    
    private int i;

    
    
    
    
    
    private void OnEnable()
    {
        i = 0;
    }
    
    
    
    public void GetNextString()
    {
        returnValue = dialog[i];
        i = (i + 1) % dialog.Count;
    }
    

    // Update is called once per frame
  public void SetTextuiToValue (Text obj)
  {
      obj.text = returnValue;
  }
}
