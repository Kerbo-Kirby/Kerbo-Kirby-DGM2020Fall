using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dsf : MonoBehaviour
{

    public intData healt;
    // Start is called before the first frame update
    void Start()
    {
        healt.value = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (healt.value <= 0)
        {
            healt.value = 0;
            Destroy(gameObject);
            
            
        }
    }
}
