using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimations : MonoBehaviour
{
    [SerializeField] public Animator playerAnim;
    [SerializeField] SpriteRenderer playerSr;
    [SerializeField] float slideTime;
    [SerializeField] float toSlideTime;
    [SerializeField] float repeatSlideTime;
    [SerializeField] PlayerMovement playerMovement;
    [HideInInspector] public bool isGrounded;
    [HideInInspector] public bool isRepeatSlide;
    [HideInInspector] public bool canRun;
    [HideInInspector] public float horizontal;
    void Start()
    {
        isRepeatSlide = true;
        isGrounded = true;
        playerAnim = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        Running();
        Jump();
        Slide();
    }
    void Running()
    {
        if (horizontal < 0 && isGrounded == true)
        {
            playerMovement.toSlide = false;
            if (playerMovement.toSlide == false && canRun == true)
            {
                playerAnim.SetInteger("RunningInt", 1);
                playerSr.flipX = true;
                if (!isGrounded)
                {
                    playerAnim.SetInteger("RunningInt", 0);
                    playerAnim.SetInteger("JumpInt", 1);
                }
            }
        }
        if (horizontal > 0 && isGrounded == true)
        {
            playerMovement.toSlide = false;

            if (playerMovement.toSlide == false && canRun == true)
            {
                playerAnim.SetInteger("RunningInt", 1);
                playerSr.flipX = false;
                if (!isGrounded)
                {
                    playerAnim.SetInteger("RunningInt", 0);
                    playerAnim.SetInteger("JumpInt", 1);
                }
            }
        }
        if (horizontal == 0)
        {
            playerMovement.toSlide = true;
            canRun = true;
            playerAnim.SetInteger("RunningInt", 2);
        }

    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerMovement.Jump();
            playerAnim.SetInteger("SlideInt", 0);
            playerAnim.SetInteger("RunningInt", 2);
            playerAnim.SetInteger("JumpInt", 1);
        }
    }
    void Slide()
    {
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (playerMovement.toSlide == true && isGrounded == true)
            {
                if (canRun && isRepeatSlide)
                {
                    playerMovement.Slide();
                    isRepeatSlide = false;
                    playerAnim.SetInteger("RunningInt", 0);
                    playerAnim.SetInteger("JumpInt", 0);
                    playerAnim.SetInteger("SlideInt", 1);
                    StartCoroutine(EndSlide());
                    StartCoroutine(ToSlide());
                    StartCoroutine(OFFSlide());
                }
            }
        }
    }
    IEnumerator EndSlide()
    {
        yield return new WaitForSeconds(slideTime);
        playerMovement.toSlide = false;
        playerAnim.SetInteger("RunningInt", 0);
        playerAnim.SetInteger("JumpInt", 0);
        playerAnim.SetInteger("SlideInt", 2);
    }
    IEnumerator ToSlide()
    {
       if (playerMovement.toSlide == false)
       {
          yield return new WaitForSeconds(toSlideTime);
          playerMovement.toSlide = true;
       }
    }
    IEnumerator OFFSlide()
    {
        yield return new WaitForSeconds(repeatSlideTime);
        isRepeatSlide = true;
    }
}
