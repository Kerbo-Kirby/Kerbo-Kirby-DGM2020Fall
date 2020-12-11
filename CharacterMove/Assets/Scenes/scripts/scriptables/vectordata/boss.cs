using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public intData bossHealth;
    void Start()
    {
        bossHealth.value = 10;
    }

    // Update is called once per frame
    void Update()
    {


        if (bossHealth.value <= 0)
        {
            Destroy(gameObject);

        }
        
        
        Time.timeScale = 0;
        


    }
}
