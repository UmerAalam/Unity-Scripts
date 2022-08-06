using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float force = 3f;
    public float gravityModifier = 9.8f;
    private Rigidbody2D playerRb;
    void Start()
    {
        
        playerRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Physics2D.gravity = new Vector2(0, -gravityModifier);
        if(Input.GetMouseButton(0))
        {
            playerRb.velocity = Vector2.up * force;
        }
    }
}
