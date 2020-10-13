using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public Transform prefab;
     public float ShootTime;
    public Vector3Data wap;
    //public GameObject player;



    IEnumerator Start()

    {

        /// var newObj = Instantiate(prefab, location , Quaternion.identity);

        ;
        Instantiate(prefab,transform.position, transform.rotation);
      //  new WaitForSeconds(ShootTime);


       yield break;

    }
    
}
