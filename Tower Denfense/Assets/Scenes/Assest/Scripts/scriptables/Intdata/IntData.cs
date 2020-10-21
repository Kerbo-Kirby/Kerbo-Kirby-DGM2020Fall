using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class IntData : ScriptableObject
{


    public int value;


    public void healthAmount(int amount)


    {
        value = amount;

        
        
        

    }
    public void damageAmount(int amount)


    {
        value = amount;


    }
    
    
    

    public void setValue(int amount)
    {

        value = amount;
        
        
        
        
        

    }


}
