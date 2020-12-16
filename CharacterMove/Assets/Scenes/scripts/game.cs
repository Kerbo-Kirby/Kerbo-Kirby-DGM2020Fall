using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class game : MonoBehaviour
{
    // Start is called before the first frame update
    

    [SerializeField] private GameObject screeen;

    void Start()
    {
        Time.timeScale = 0f;
        screeen.SetActive(false);
    }

    // Update is called once per frame
 
        public void StartGame()
        {
            Application.Quit();
            screeen.SetActive(false);
            Time.timeScale = 1f;
           
        }
    }

