using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick : MonoBehaviour
{
    public Transform nana;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        //if (player.CompareTag("Player"))

        //  {
       // if (nana == null) return;
        if (nana.name == ("Player"))
        {
            transform.parent = nana.transform;

        }



       // private void OnTriggerExit(Collider other)
        //{
         //   transform.parent = null;
       // }
   // }

}
// if(nana == null) return;
        
       // if (nana.name == "Player")
        
          //  transform.parent = nana.transform;

}

