using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterKnockBack : MonoBehaviour

    {
    private CharacterController controller;

    Vector3 move = Vector3.left;
    void Update()
    {
        controller = GetComponent<CharacterController>();
        controller.Move(move*Time.deltaTime);
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        var i = 2f;
        move = other.attachedRigidbody.velocity * i;
        while (i > 0)
        {
            yield return new WaitForFixedUpdate();
            i -= 0.1f;
        }

        move = Vector3.left;
    }

    public float powerPush;
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        var body = hit.collider.attachedRigidbody;


        if (body == null || body.isKinematic)

        {
            return;
        }


        //var pushDir = new vector3(RaycastHit, MoveDirection.x, 0, hit.moveDirecrion.z);

       //var forces = 

            
            
            
            
    }
    
    
    
}

