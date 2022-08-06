using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorPlatform : MonoBehaviour
{
    [SerializeField] Rigidbody2D rotatorPlatformRb;
    [SerializeField] float speed;
    float horizontal;
    
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal") * speed;
        Movement();
        StopMoveZ();
    }
    void Movement()
    {
        transform.Rotate(Vector3.forward * -horizontal);
    }
    void StopMoveZ()
    {
        if (horizontal == 0)
        {
            rotatorPlatformRb.freezeRotation = true;
        }
        else
        {
            rotatorPlatformRb.freezeRotation = false;
        }
    }
}
