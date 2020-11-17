using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{


    public bool pauseTime = false;




   

   

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pauseTime)

                Time.timeScale = 1f;



            else
                Time.timeScale = 0f;
            pauseTime = !pauseTime;

        }


    }
}






