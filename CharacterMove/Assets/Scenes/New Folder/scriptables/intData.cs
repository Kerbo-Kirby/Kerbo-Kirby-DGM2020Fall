using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu]
public class intData : ScriptableObject


{


    public int value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void  health(int amount)
    {
        value += 1;
    }

    public void damage(int amount)
    {
        value -= 1;
    }
    
    

    
}
