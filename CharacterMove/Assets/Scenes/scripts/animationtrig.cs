using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class animationtrig : MonoBehaviour
{
    // Start is called before the first frame update
    public bool enter;
    public Animator hazard;
    public Animation hung;
    void Start()
    {
        hazard = GetComponent<Animator>();
        hazard.Play(hung.name);
    }

    // Update is called once per frame
    public void Update()
    {

    }

    public void OnTriggerEnter(Collider gameobject)
    {
        
    }
}
