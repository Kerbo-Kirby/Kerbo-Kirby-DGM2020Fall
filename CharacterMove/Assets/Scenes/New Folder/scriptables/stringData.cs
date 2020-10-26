using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class stringData : ScriptableObject
{
    private string returnValue;
    
    // it will cdreat a list of dialog to input into
    public List<string> dialog;
    
    
    private int didi;

    
    
    private void OnEnable()
    {
        didi = 0;
    }
    
    
// this will return it to the next value and gets the next string
    public void SetTextuiToValue (Text obj)
    {
        returnValue = dialog[didi];
        didi = (didi + 1) % dialog.Count;
        
        obj.text = returnValue;
    }
}
