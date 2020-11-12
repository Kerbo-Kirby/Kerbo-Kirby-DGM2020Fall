using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePlayerLoc : MonoBehaviour
{
    public Vector3Dataq changeLoc;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        
        player.transform.position = changeLoc.value;
    }
}
