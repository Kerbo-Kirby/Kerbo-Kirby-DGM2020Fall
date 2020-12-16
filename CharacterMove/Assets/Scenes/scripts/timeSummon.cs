
using System;
using UnityEngine;

using UnityEngine.Events;

public class timeSummon : MonoBehaviour
{

    public float timeApper;

    public GameObject l;

    public void Start()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(l);
    }
}

