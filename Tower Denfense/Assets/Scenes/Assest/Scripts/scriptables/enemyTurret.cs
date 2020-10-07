using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTurret : MonoBehaviour
{


    public Vector3 aim;

    public Transform obj;
    public float move;



    void Start()
    {
        aim = GetComponent<Vector3>();
    }

    // Update is called once per frame
    void Update()
    {


        transform.LookAt(obj);

        while (move < 0)
        {
            new WaitForSeconds(1);
            transform.Translate(-0.1f, 0, 0);
            move++;
        }
        
        


    }

}
