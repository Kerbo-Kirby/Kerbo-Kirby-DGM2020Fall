﻿using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class stick : MonoBehaviour
{
  ////  public Transform nana;

    public GameObject player;






    void OnTriggerEnter(Collider other)
    {
     if (other.gameObject == player)
     {
player.transform.parent = transform;
     }
    }

    void OnTriggerExit(Collider other)
    {
     if (other.gameObject == player)
     {

      player.transform.parent = null;
     }
    }






















    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    //public void OnTriggerEnter(Collider other)
   // {

       // if (player == null) return;
      //  if (idObj == newObj.idObj)
     //   {

         //  transform.parent = other.transform;

      //  }

   // }

  //  private void OnTriggerExit(Collider p)
 //   {
///{
   //     transform.parent = null;
 //   }
}




// if(nana == null) return;
        
       // if (nana.name == "Player")
        
          //  transform.parent = nana.transform;



