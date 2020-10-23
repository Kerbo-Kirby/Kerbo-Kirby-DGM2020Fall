using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierTrigger : MonoBehaviour
{
    public Transform obj;
    public Vector3 speed;

    public Vector3Data loc;

  
    
    private void Start()
    {


      

    }

    public void OnTriggerEnter(Collider other)
    {
       
        speed = transform.position * Time.deltaTime;
        Instantiate(obj, loc.value, Quaternion.Euler(loc.value));
  
        
        
        ///this made it a bomb im keeping this for later
        //   if (gameObject)
      //  {
         //   gameObject.SetActive(false);

         //   speed = transform.position * Time.deltaTime;
            
         //   gameObject.SetActive(true);

         return; //new WaitForSeconds(1);
         //  }
    }

}
