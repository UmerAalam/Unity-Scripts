using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    public static PlayerJump instance;
    [SerializeField] Rigidbody2D playerBody;
    [SerializeField] Animator playerAnim;

    [SerializeField] float forceX, forceY;
    [SerializeField] float thresHoldX, thresHoldY;
    bool setPower,didJump;

    private void Awake()
    {
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
        ReloadScene();
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
        }
    }

    public void SetPower(bool setPower)
    {
        this.setPower = setPower;
        if (!setPower)
        {
            Jump();
        }
    }
    void Jump()
    {
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
                if(GameManager.instance != null)
                {
                    GameManager.instance.CreateNewPlatformAndLerp(collision.gameObject.transform.position.x);
                }
            }
        }
    }
    void ReloadScene()
    {
        if(transform.position.y <= -7f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
