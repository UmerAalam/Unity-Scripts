using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] Sounds jumpClip;
    [SerializeField] Animator playerAnimator;
    [SerializeField] float jumpTime = 0.01f;
    [SerializeField] public float forwardForce;
    [SerializeField] Rigidbody2D myBody;
    [SerializeField] Button jumpBtn;
    [HideInInspector] public float jumpForce;
    [SerializeField] GameObject dustJump;
    [SerializeField] Transform particleSpace;
    bool canJump;
    private void Awake()
    {
        jumpForce = PlayerPrefs.GetFloat("JumpForce");
        myBody.gravityScale = PlayerPrefs.GetFloat("Gravity");
        myBody.mass = PlayerPrefs.GetFloat("Mass");
        forwardForce = PlayerPrefs.GetFloat("ForwardForce");
        playerAnimator = GetComponent<Animator>();
        myBody = GetComponent<Rigidbody2D>();
        jumpBtn = GameObject.Find("JumpButton").GetComponent<Button>();
        jumpBtn.onClick.AddListener(() => Jump());
    }

    void Update()
    {

        forwardForce = PlayerPrefs.GetFloat("ForwardForce");
        jumpForce = PlayerPrefs.GetFloat("JumpForce");
        myBody.gravityScale = PlayerPrefs.GetFloat("Gravity");
        myBody.mass = PlayerPrefs.GetFloat("Mass");
    }
    public void Jump()
    {
        playerAnimator.Play("Jump");
        if (canJump)
        {
            jumpClip.PlayJumpClip();
            if (transform.position.x <= 0)
            {
                forwardForce = PlayerPrefs.GetFloat("ForwardForce");
            }
            else
            {
                forwardForce = 0f;
            }
            myBody.AddForce(Vector2.up * jumpForce);
            myBody.AddForce(Vector2.right * forwardForce);
            StartCoroutine(FalseCanJump());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Obstacle"))
        {
            canJump = true;
            Instantiate(dustJump,particleSpace.transform.position,Quaternion.identity);
            Destroy(dustJump, 1f);
        }
        if (collision.gameObject.CompareTag("Obstacle"))
            forwardForce *= 2f;
        if (collision.gameObject.CompareTag("Ground"))
        {
         Instantiate(dustJump, particleSpace.transform.position, Quaternion.identity);
         Destroy(dustJump, 1f);
        }
    }
    IEnumerator FalseCanJump()
    {
        yield return new WaitForSeconds(jumpTime);
        canJump = false;
    }
}











































