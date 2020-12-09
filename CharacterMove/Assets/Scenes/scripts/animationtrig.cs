using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class animationtrig : MonoBehaviour


   
    {
        private void Update()
        {
if(Input.GetKey(KeyCode.G))
            if (gameObject.CompareTag("Player")) {
                GetComponent<Animator>().SetTrigger("Move");
            }
        }
    }

