using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quit : MonoBehaviour
{


    public bool start;
public float imagetime;
    public float startTime;
    public Image scrren;
    public float timeLimitation;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("rff");
    }

    // Update is called once per frame
    public void Update()
    {
        Application.Quit();
    }

   IEnumerator rff ()
    {
        startTime += Time.deltaTime * 10f;
        
while(startTime > timeLimitation)
        
        start = true;
yield return new WaitForSeconds(imagetime);
start = false;
startTime = 0;

    }

   public void imagesd()
   {
       if (start)
       {
           
       }
   }

}
