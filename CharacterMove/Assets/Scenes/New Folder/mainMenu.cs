using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{

    [SerializeField] private GameObject pauseMenu;


    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pauseMenu)


                pauseMenu.SetActive(true);


            else

                pauseMenu.SetActive(false);
            
        }
    }


}
