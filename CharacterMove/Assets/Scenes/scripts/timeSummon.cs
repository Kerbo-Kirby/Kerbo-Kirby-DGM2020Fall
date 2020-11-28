
using UnityEngine;


public class timeSummon : MonoBehaviour
{

    public float timeApper;

    public GameObject objectApper;

    public void Start()
    {
       objectApper.SetActive(false);
     
    }


    public void Update()
    {


        objectApper.SetActive(true);


        
        }
}
