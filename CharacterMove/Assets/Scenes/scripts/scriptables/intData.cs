using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu]
public class intData : ScriptableObject


{

    //public healthBar healthslider;
    public int value;
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    public void  increase(int amount)
    {
        value += 1;
    }

    public void decrease(int amount)
    {
        value -= 1;
        
      ///  healthslider.BarHealth();
    }


    public void healthPickUp1()
    {
        value = 2;
    }
    public void healthpickup2()
    {
        value = 2;
    }
    
    
    public void powerUp()
    {
        value = 2;
    }
    
}
