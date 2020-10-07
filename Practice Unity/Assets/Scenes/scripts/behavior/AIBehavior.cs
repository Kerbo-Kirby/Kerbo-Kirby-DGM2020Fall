using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class AIBehavior : MonoBehaviour
{
  
    private UnityEngine.AI.NavMeshAgent agent;
       
       
    public Transform player;
    
    
    private void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    private void Update()
    {
        agent.destination = player.position;
        print("walking");
    }
}

