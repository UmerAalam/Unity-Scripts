using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D carRb;
    [SerializeField] float speed = 5f;
    [SerializeField] float rotationSpeed = 5f;
    float movement;
    float rotation;
    void Start()
    {
        carRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
    }
    void FixedUpdate()
    {
        carRb.AddForce(Vector2.up * movement);
        carRb.AddTorque(-rotation);
    }
}
