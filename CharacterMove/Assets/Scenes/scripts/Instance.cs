using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    public GameObject bullet;
    
   
    public Vector3Dataq bang;
    public CharacterController cont;
  
    //.///public vector3Data bang;


    public int damage = 1;
    public int time = 5;

    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            var hit = other.gameObject;

            
            // var health = hit.GetComponent<enemeyhealth>();

            //    if (health != null)
            // {
            //  .// health.TakeDamage(damage);
            //Debug.Log("Ouch, you hit me!");
            // }

        }

    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
    
    
   // public void instance ()
   // {
// velocity of the rigid body


     //   var location = transform.position;
      //  var newObj = Instantiate(bullet);
      //  print(bang.value);
       // print(newObj.transform.eulerAngles);

    }

