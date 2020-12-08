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

    private NavMeshAgent secretAgent;
    public List<Vector3> ppPoints;

    void Start()
    {

        secretAgent = GetComponent<NavMeshAgent>();

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

