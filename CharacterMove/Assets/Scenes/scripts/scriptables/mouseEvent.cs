using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class mouseEvent : MonoBehaviour
{
    
    public float holdTime = 0.5f;
    public UnityEvent startEvent, onCallEvent, restartLoopEvent;
    public int instanceCount = 10;
    
    private WaitForSeconds wfs;
    
    private int counter = 0;
    private void Start()
    {
        wfs = new WaitForSeconds(holdTime);
        startEvent.Invoke();
    }

    public void StartLoopEvents()
    {
        StartCoroutine(CallInstanceEvent());
    }
    
    private IEnumerator CallInstanceEvent()
    {
        while (counter < instanceCount)
        {
            onCallEvent.Invoke();
            counter++;
            yield return wfs;
        }
        counter = 0;
        restartLoopEvent.Invoke();
    }
}
