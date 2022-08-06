using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{
    Rigidbody wheelRb;
    [SerializeField] float moveForce = 10f;
    [SerializeField] float rotationForce = 10f;
    [SerializeField] float gravityModifier = 10f;
    
    void Start()
    {
        wheelRb = GetComponent<Rigidbody>();
        wheelRb.mass = 20;
        
    }
    void Update()
    {
        Physics.gravity = new Vector3(0, -gravityModifier, 0);
        Movement();
    }
    void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        wheelRb.AddForce(Vector3.forward * horizontal * moveForce, ForceMode.Impulse);
        wheelRb.AddTorque(Vector3.forward * horizontal * rotationForce, ForceMode.Impulse);
    }
    
}
