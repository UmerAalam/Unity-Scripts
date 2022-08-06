using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : TapEnabler
{
    public GameManager gameManager;
    public float jumpForce;
    public Rigidbody2D birdRb;
    private Physics2D gravity;
    public float gravityChanger = 0;

    void Start()
    {
        birdRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Physics2D.gravity = new Vector2(0, -gravityChanger);
        Jump();
    }

    void Jump()
    {
        if(Input.GetMouseButtonDown(0))
        {
            birdRb.velocity = Vector2.up* jumpForce;
        }
    }
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOverScreen();
    }
}
