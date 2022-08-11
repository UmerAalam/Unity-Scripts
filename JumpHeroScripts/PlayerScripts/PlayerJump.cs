using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour
{
    public static PlayerJump instance;
    [SerializeField] Rigidbody2D playerBody;
    [SerializeField] Animator playerAnim;
    [SerializeField] float forceX, forceY;
    [SerializeField] float thresHoldX, thresHoldY;
    [SerializeField] Slider powerBar;
    bool setPower,didJump;

    private void Awake()
    {
        GetPowerBar();
        MakeInstance();
    }
    void Initialize()
    {
        playerAnim = GetComponent<Animator>();
        playerBody = GetComponent<Rigidbody2D>();
    }
    void MakeInstance()
    {
        if (instance == null)
            instance = this;
    }
    private void Update()
    {
        SetPower();
    }
    void SetPower()
    {
        if(setPower)
        {
            forceX += thresHoldX * Time.deltaTime;
            forceY += thresHoldY * Time.deltaTime;

            if (forceX > 6.5f)
                forceX = 6.5f;
            if (forceY > 13.5f)
                forceY = 13.5f;
            powerBar.value = forceX + forceY;
        }
    }

    public void SetPower(bool setPower)
    {
        this.setPower = setPower;
        if (!setPower)
        {
            powerBar.value = 0f;
            Jump();
        }
    }
    void Jump()
    {
        playerAnim.SetBool("Jump",true);
        playerBody.velocity = new Vector2(forceX,forceY);
        forceX = forceY = 0f;
        didJump = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(didJump)
        {
            didJump = false;
            if (collision.gameObject.CompareTag("Platform"))
            {
                playerAnim.SetBool("Jump", false);
                if (GameManager.instance != null)
                {
                    GameManager.instance.CreateNewPlatformAndLerp(collision.gameObject.transform.position.x);
                }
                if(ScoreManager.instance != null)
                {
                    ScoreManager.instance.IncrementScore();
                }
            }
        }
        if(collision.gameObject.CompareTag("Dead"))
        {
            GameOver.instance.ShowGameOverPanel();
        }
    }
    void GetPowerBar()
    {
        powerBar = GameObject.Find("PowerBar").GetComponent<Slider>();
        powerBar.value = 0f;
    }
}
