using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] KeyCode jumpKey;
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] float gravityModifier;
    [SerializeField] Rigidbody2D playerRb;
    float horizontalInput;
    bool isGrounded;
    
    

    void Start()
    {
        tra
        isGrounded = false;
        playerRb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Physics2D.gravity = new Vector2(0,gravityModifier);
     horizontalInput = Input.GetAxisRaw("Horizontal");   
    }
    void FixedUpdate()
    {
        Movement();
        Jump();
    }
    void Movement()
    {
        playerRb.AddForce(Vector2.right * moveSpeed * horizontalInput);
    }
    void Jump()
    {
        if (Input.GetKeyDown(jumpKey) && isGrounded)
        {
            playerRb.AddForce(Vector2.up * jumpForce);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
     if(collision.gameObject.CompareTag("Ground"))
     {
        isGrounded = true;
     }  
    }
}
