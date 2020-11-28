using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class floatData : MonoBehaviour
{
    public float value;

    public void UpdateValue(float number)
    {
        value += number;
    }
    
    
    public void SetImageFillAmount(Image imaag)
    {
        if (value >= 0 || value <= 1)
        {
            imaag.fillAmount = value;
        }
    }
    
}




