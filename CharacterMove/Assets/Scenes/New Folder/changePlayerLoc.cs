using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changePlayerLoc : MonoBehaviour
{
    public Vector3Dataq changeLoc;
   /// public Transform transLoc;

    public GameObject player;
  // Update is called once per frame


 /// public int index;
  public string newScene;


  public GameObject cam;
  public GameObject otherCam;
  

 
  void OnTriggerEnter(Collider other)
  {


      if (player.gameObject.CompareTag("Player"))
      {
          player.gameObject.transform.position = changeLoc.value;




          SceneManager.LoadSceneAsync(newScene, LoadSceneMode.Additive);




          //SceneManager.LoadScene(newScene, LoadSceneMode.Additive);

          SceneManager.GetActiveScene();

          SceneManager.MoveGameObjectToScene(player, SceneManager.GetSceneByName(newScene));
          SceneManager.MoveGameObjectToScene(cam, SceneManager.GetSceneByName(newScene));
          SceneManager.MoveGameObjectToScene(otherCam, SceneManager.GetSceneByName(newScene));


        
          SceneManager.UnloadSceneAsync(1);
          
          
          //Debug.Log("Loading " + switchSceneTo + " Scene"); 
          
      }

  }
}
