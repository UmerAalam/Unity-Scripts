using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float speed;
    public float jump;
    public float gravity;
    private bool isGrounded;

    void Start()
    {
        isGrounded = true;
        playerRb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(0, 0);
    }

    void Update()
    {
        Physics2D.gravity = new Vector2(0, gravity);
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * speed * Time.deltaTime, 0, 0);
        Jump();
    }

    public void Jump()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRb.AddForce(transform.up * jump,ForceMode2D.Impulse);
            isGrounded = false;
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!isGrounded)
        {
            isGrounded = true;
        }
    }
}
    
