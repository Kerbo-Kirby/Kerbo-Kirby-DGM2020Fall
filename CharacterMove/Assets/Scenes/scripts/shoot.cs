using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class shoot : MonoBehaviour
{
 public Transform prefab;

 public Vector3 spa;

 // public Vector3Dataq ban;
 public CharacterController con;


 /// public Transform shot;
 public GameObject bullter;
 //public float speed;




 public Vector3Dataq dance;
 // public Vector3 dis;



 // public void instancevv()

 public void Update()
 {




  if (Input.GetMouseButtonDown(0))
  {

   var velocity = con.velocity;

   // var ray = Camera.main.ScreenPointToRay (Input.mousePosition);

   
 ///var posistion = (Input.mousePosition.x, Input.mousePosition.y, dance);
   
   
   
   bullter.transform.LookAt(Input.mousePosition);

    if (!prefab)
     bullter = GameObject.Find("oneSpawn");
   
   Instantiate(prefab, velocity, Quaternion.identity);



   if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hit, 1)) ;

   // turn the projectile to hit.point
   // transform.LookAt(Input.mousePosition);

   // // accelerate it
   
   
   
Destroy(gameObject);
   











   // i noticed every script i looked at had this//the instance calls it and the velocity is a vector 3 while the wyaternion is a rotation
   // ///Instantiate(prefab, velocity, Quaternion.identity);
   //  bullter.transform.LookAt(Input.mousePosition);

   // public Vector3Data mouseLocation;
   // private Camera cam;







  }
 }
}
   

  
