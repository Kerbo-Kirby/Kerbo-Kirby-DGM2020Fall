using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyConfig : MonoBehaviour
{

   private EnemyHealth eHealth;


  void Start()
   {
      
      eHealth ScriptableObject.CreateInstance<EnemyHealth>();
   }


  private void ontrigger
  {
      eHealth.value -= 0.3f
  }
}
