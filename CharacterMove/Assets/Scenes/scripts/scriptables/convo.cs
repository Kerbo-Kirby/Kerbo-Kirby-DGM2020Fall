using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




[System.Serializable]
public struct line
{
    public charaBox character;

   [TextArea(2,5)]
    
    public string text;

}
[CreateAssetMenu(fileName = "newcon", menuName = "convo")]
public class convo : ScriptableObject
        {
    
  


public charaBox spek;
public line[] lines;





        }
