using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public SetAnimations setanimations;
    [SerializeField] SpriteRenderer playerSr;
    [SerializeField] float jumpForce =10f;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float slideSpeed = 10f;
    [SerializeField] float playerSpeed =10f;
    [SerializeField] float jumpTime = 0.1f;
    [HideInInspector] public bool toSlide;

    void Start()
    {
        toSlide = true;
        playerRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
      Movement();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            setanimations.canRun = true;
            setanimations.isGrounded = true;
            setanimations.playerAnim.SetInteger("JumpInt", 2);
        }
    }
    public void Jump()
    {
        if (setanimations.isGrounded == true)
        {
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            StartCoroutine(Grounded());
        }
    }
    public void Slide()
    {
        if (setanimations.isRepeatSlide)
        {
            if (playerSr.flipX == false && setanimations.canRun == true)
            {
                if (toSlide && setanimations.isGrounded)
                    playerRb.AddForce(Vector2.right * slideSpeed, ForceMode2D.Impulse);
            }

            if (playerSr.flipX == true && setanimations.canRun == true)
            {
                if (toSlide && setanimations.isGrounded)
                    playerRb.AddForce(Vector2.left * slideSpeed, ForceMode2D.Impulse);
            }
        }
          
    }
    public void Movement()
    {
       if (setanimations.horizontal < 0)
       {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
       }
       if (setanimations.horizontal > 0)
       {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
       }
    }
    IEnumerator Grounded()
    {
        yield return new WaitForSeconds(jumpTime);
        setanimations.canRun = false;
        setanimations.isGrounded = false;
    }
}


