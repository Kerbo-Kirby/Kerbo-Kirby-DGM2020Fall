using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{


    public static bool pauseTime;

    [SerializeField] private GameObject pauseMenu;

    public void Start()
    {
        pauseMenu.SetActive(false);
    }

    
    
    
    
    
    
    void PPause()
    {
        if (pauseTime)
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);


        }

        else
        {
            pauseMenu.SetActive(false);

            Time.timeScale = 1f;
        }
    }

    
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            pauseTime = pauseMenu;
            PPause();
        }
    }


    
}





        


    






