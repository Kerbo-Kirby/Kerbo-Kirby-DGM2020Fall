using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3Dataq locChange;

    public GameObject player;
    public float dk;
    public GameObject por;

    void Start()
    {


    }

    public void OnTriggerEnter(Collider other)
    {

        {
          //  if (other.gameObject.CompareTag("Player") == player)

               //other.transform.position = locChange.value;

            ///locChange.value = other.gameObject.transform.position;
            Debug.Log("im ober here");
        }
    }
}
// else 
// Debug.Log("what happended?");
