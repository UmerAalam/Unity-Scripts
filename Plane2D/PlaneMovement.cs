using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D planeRb;
    [SerializeField] float forceStrenght;
    [SerializeField] float rotationStrenght;
    float horizontal;
    float vertical;

    void Start()
    {
        planeRb = GetComponent<Rigidbody2D>(); 
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
   }

    void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        planeRb.AddRelativeForce(Vector3.up *forceStrenght * Time.deltaTime * vertical);
        transform.Rotate(Vector3.forward * rotationStrenght * horizontal);
    }
}
