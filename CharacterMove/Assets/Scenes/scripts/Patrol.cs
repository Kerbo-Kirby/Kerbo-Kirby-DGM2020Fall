using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;





[RequireComponent(typeof(NavMeshAgent))]
public class Patrol : MonoBehaviour
{

    private WaitForFixedUpdate wtf = new WaitForFixedUpdate();

    public Transform player;
    private bool canHurt, canPP;

    private NavMeshAgent secretAgent;
    private Transform des;
    public List<Vector3Dataq> ppPoints;

    void Start()
    {

        secretAgent = GetComponent<NavMeshAgent>();

        StartCoroutine(guardPoint());
    }
    private IEnumerator OnTriggerEnter(Collider other)
    {
        canHurt = true;
        canPP = false;
        secretAgent.destination = des.position;
        var distance = secretAgent.remainingDistance;
        while (distance <= 0.25f)
        {
            distance = secretAgent.remainingDistance;
            yield return wtf;
        }
        yield return new WaitForSeconds(2f);

        StartCoroutine(canHurt ? OnTriggerEnter(other) : guardPoint());
    }
    
    
    
    
    private void OnTriggerExit(Collider other)
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
            if (secretAgent.pathPending || !(secretAgent.remainingDistance < 0.8)) continue;
            secretAgent.destination = ppPoints[i].value;
            i = (i + 1) % ppPoints.Count;
        }
    }

  
}