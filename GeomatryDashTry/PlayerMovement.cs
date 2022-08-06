using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float gravityChanger;
    public float jumpForce;
    private Rigidbody2D playerRb;
    private bool isGrounded;
    public float jumpGravity;

    void Start()
    {
        jumpGravity = 0.4f;
        playerRb = GetComponent<Rigidbody2D>();
        isGrounded = false;
    }

    void Update()
    {
        Physics2D.gravity = new Vector2(0, -gravityChanger);
        //Calling Player Movement Function
        PlayerMove();
    }
    //Player Movement Function
    void PlayerMove()
    {
        // Input Controls
        if(Input.GetButtonDown("Mouse") && isGrounded == true)
        {
            // Add Jump Force 
            playerRb.AddForce(transform.up * jumpForce);
            isGrounded = false;
            //Play Jump Animation
        }
        if(transform.position.y >= -jumpGravity)
        {
            gravityChanger = 50;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Detect Collisions
        if(collision.gameObject.tag == "Ground")
        {
            gravityChanger = 20;
            isGrounded = true;
        }
    }


}
