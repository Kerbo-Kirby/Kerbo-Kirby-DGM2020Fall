using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemeyhealth : MonoBehaviour
{
    // Start is called before the first frame update

    public intData enumhealth;
    void Start()
    {
        enumhealth.value = 3;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (enumhealth.value <= 0)
        {
            Destroy(gameObject);
            
        }


    
        }
    }
    
            
        

