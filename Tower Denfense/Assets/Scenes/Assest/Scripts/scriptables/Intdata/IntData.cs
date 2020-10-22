using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class IntData : ScriptableObject
{


    public int value;
    
    
        
        
        
    
    public void setValue(int amount)
    {

        value = amount;
        
        
        
        
        

    }
    
    public void healthAmountPowerUp(int amount)


    {

        
        
        
        value += amount;


       



    }
    public void damageAmount(int amount)


    {
        value -= amount;
      

    }
    
    
    

   


}
