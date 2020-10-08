using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTurret : MonoBehaviour
{


    public Vector3 aim;

    public Transform obj;
    public float move;


    public Vector3 vOne,vTwo; 
   
    public float value;


    public Vector3 pA = new Vector3(0,0,0), pB = new Vector3(25,0,3);
    void Start()
    {
        aim = GetComponent<Vector3>();
    }

    // Update is called once per frame
    void Update ()
    {


        transform.LookAt(obj);

      //  if (pA != pB)
     //   {
          //  value += 0.1f * Time.deltaTime;
          //  transform.position = Vector3.Lerp(pA, pB, value);
          //  transform.Translate(0,0,Time.deltaTime);
     //   }


// var direction = Vector3.Lerp(vOne,vTwo,value); 
      // value += 0.1f * Time.deltaTime; 
       // transform.Translate(direction);
      
    }
    
    
    

}
