using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLocationBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefab;
    public Vector3 mouseLocation;
    private Camera cam;
    
    public void Start()
    {

        cam = Camera.main;

        Cursor.visible = true;
    }

    void Update()
    {
        if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out var hit, 100))
        {
            mouseLocation = hit.point;

            Debug.Log("lememe");
        }
        
         
        
    }
}
