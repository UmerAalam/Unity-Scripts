using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerRb;
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
     
    }
    void FixedUpdate() 
    {
        Movement();
    }
    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput,0,verticalInput);
        playerRb.AddForce(moveDirection * moveSpeed);
    }
    
}
