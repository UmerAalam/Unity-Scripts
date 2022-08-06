using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject bulletSpawnerPosition;
    bool isGrounded;
    bool isRunning;
    bool isShooting;
    Animator playerAnimator;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        isShooting = false;
        isGrounded = true;
        isRunning = false;
    }

    void Update()
    {
        AnimationController();
        Movement(Input.GetAxis("Horizontal"), 10f, GetComponent<SpriteRenderer>());
        Jump(GetComponent<Rigidbody2D>(), 30f);
        ShootingAnimationSet();

    }
    void Movement(float horizontal, float moveSpeed, SpriteRenderer playerSr)
    {
        transform.Translate(Vector2.right.normalized * moveSpeed * horizontal * Time.deltaTime);

        if (horizontal > 0f)
        {
            isRunning = true;
            playerSr.flipX = false;
        }
        if (horizontal < 0f)
        {
            isRunning = true;
            playerSr.flipX = true;
        }
        if (horizontal == 0f)
        {
            isRunning = false;
        }
    }
    void Jump(Rigidbody2D playerRb, float jumpPower)
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRb.velocity += new Vector2(0, jumpPower);
        }

    }
    void ShootingAnimationSet()
    {
        if (Input.GetKeyDown(0))
        {
            isShooting = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    void AnimationController()
    {
        if (isGrounded == true)
        {
            playerAnimator.SetBool("IsIdle", true);
            playerAnimator.SetBool("IsRunning", false);
            playerAnimator.SetBool("IsJumping", false);

            playerAnimator.SetInteger("Shooting", 0);
        }
        if (isGrounded == false)
        {
            playerAnimator.SetBool("IsIdle", false);
            playerAnimator.SetBool("IsRunning", false);
            playerAnimator.SetBool("IsJumping", true);
        }
        if(isRunning == true && isGrounded == true)
        {
            playerAnimator.SetBool("IsIdle", false);
            playerAnimator.SetBool("IsRunning", true);
            playerAnimator.SetBool("IsJumping", false);
        }

    }
   


}