using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;





[RequireComponent(typeof(NavMeshAgent))]
public class Patrol : MonoBehaviour
{



    private WaitForFixedUpdate wtf = new WaitForFixedUpdate();

   /// public Transform player;
    private bool canHurt, canPP;
   private Transform destination;
    private NavMeshAgent secretAgent;
    public List<Vector3> ppPoints;
    public Transform player;
    
    
   
   public float speed;
    void Start()
    {

        secretAgent = GetComponent<NavMeshAgent>();
     //   destination = transform;
      StartCoroutine(guardPoint());
    }

  

    private IEnumerator OnTriggerEnter(Collider other)
    {
        canHurt = true;
        canPP = false;
        secretAgent.destination = player.position;
        
        //transform.LookAt(player);
      
        
        var distance = secretAgent.remainingDistance;
        
        
        
        
        while (distance <= 0.25f)
        {
            distance = secretAgent.remainingDistance;
            yield return wtf;
        }

        yield return new WaitForSeconds(2f);

        StartCoroutine(canHurt ? OnTriggerEnter(other) : guardPoint());
    }


    public void OnTriggerExit(Collider other)
    {

        canHurt = false;
        StartCoroutine(guardPoint());
    }

    private int i = 0;
    
    private IEnumerator guardPoint()
    {
        canPP = true;

        while (canPP)

        {
            yield return wtf;
            if (secretAgent.pathPending || !(secretAgent.remainingDistance < .5)) continue;
            secretAgent.destination = ppPoints[i];
            i = (i + 1) % ppPoints.Count;
        }

    }
}

