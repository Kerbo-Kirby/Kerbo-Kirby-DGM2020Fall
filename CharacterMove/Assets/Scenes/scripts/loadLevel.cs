using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadLevel : MonoBehaviour
{
    ///from what i learned in anthonys class and a bit of my own
    [SerializeField] private GameObject screeen;

    public GameObject bar;

    public void Start()
    {
        Time.timeScale = 0f;
        bar.SetActive(false);
        
    }
    
    public void StartGame()
    {
        Application.Quit();
        screeen.SetActive(false);
        Time.timeScale = 1f;
        bar.SetActive(true);
    }
  
}
