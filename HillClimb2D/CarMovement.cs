using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody2D fronttire;
    public Rigidbody2D backtire;
    public Rigidbody2D carRb;
    [SerializeField] float speed = 100f;
    [SerializeField] float carTorque = 10f;

    float movement;
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }
    void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {

        fronttire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        backtire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        carRb.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
    }
}
