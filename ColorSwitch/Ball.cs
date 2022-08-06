using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float force = 4f;
    private Rigidbody2D ball;
    public RingSpawner spawnCircle;  
    public string currentColor;
    public SpriteRenderer sr;
    public Color cyan;
    public Color pink;
    public Color purple;
    public Color yellow;

    private void Start()
    {
        Time.timeScale = 1;
        ball = GetComponent<Rigidbody2D>();
        SetRandomColor();
    }
    void Update()
    {
        Jump();
    }
    void Jump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ball.velocity = Vector2.up * force;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);

        if (collision.tag == currentColor)
        {
            Debug.Log("OK");
            spawnCircle.GetComponent<RingSpawner>().StartCoroutine("SpawnCircle");
        }
        if (collision.tag != currentColor)
        {
            GameOver();
        }
       
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = cyan;
                    break;
            case 1:
                currentColor = "Yellow";
                sr.color = yellow;
                break;
            case 2:
                currentColor = "Purple";
                sr.color = purple;
                break;
            case 3:
                currentColor = "Pink";
                sr.color = pink;
                break;
        }
    }
    void GameOver()
    {
        Time.timeScale = 0;
        Destroy(gameObject);
        Debug.Log("Game Over");
    }


}
