using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ememyFire : MonoBehaviour
{




    public Transform prefab;
   // public float ShootTime;
    //public Vector3Data wap;
    IEnumerator Start()

    {
        
        var newObj = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);

       // var location = transform.position;
       // var newObj = Instantiate(prefab, location, Quaternion.Euler(wap.value));

        yield return new WaitForSeconds(1);
    }
}