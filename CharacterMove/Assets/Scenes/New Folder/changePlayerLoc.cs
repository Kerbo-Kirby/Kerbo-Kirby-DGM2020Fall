using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changePlayerLoc : MonoBehaviour
{
    public Vector3Dataq changeLoc;
    public Transform transLoc;

    public GameObject player;
  // Update is called once per frame


  public int index;
  public string area1;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

            SceneManager.LoadScene(index);
        SceneManager.LoadScene(area1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                     //  transform.position = changeLoc.value;
    }
}
