using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] Animator playerAnimator;

    void Awake()
    {
        playerAnimator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            playerAnimator.Play("Run");
        }
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            playerAnimator.Play("Idle");
        }
    }

}
