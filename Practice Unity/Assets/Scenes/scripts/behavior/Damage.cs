using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float waitTIme = 2f;
        
    public IntData damageMax, damageCount;


    private void Start()
    {

        damageCount.value = damageMax.value;
    }

    public IEnumerator OnTriggerEnter(Collider other)
    {
       
            
        yield return new WaitForSeconds(waitTIme);
        damageCount.value = damageMax.value;
        gameObject.SetActive(false);
    }
}
