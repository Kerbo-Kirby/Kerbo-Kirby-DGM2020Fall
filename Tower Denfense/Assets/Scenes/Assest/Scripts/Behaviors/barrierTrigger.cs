using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierTrigger : MonoBehaviour
{
    public GameObject obj;
    public Vector3 speed;

    public Vector3Data loc;

    public void  start()
    {
        
        
       obj.SetActive(false);
        
    }
    
 
    public void OnTriggerEnter(Collider other)
    {

        obj.transform.position = loc.value;
        
        obj.SetActive(true);
        
        ///this made it a bomb im keeping this for later
        //   if (gameObject)
      //  {
         //   gameObject.SetActive(false);

         //   speed = transform.position * Time.deltaTime;
            
         //   gameObject.SetActive(true);

      
         //  }
    }

}
