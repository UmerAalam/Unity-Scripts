using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    private Vector2 targetPos;
    public float yIncrement;

    public float speed;

    public float maxHeight;
    public float minHeight;

    public int health = 3;

    public Animator camAnim;

    void Start()
    {
        health = 3;
    }

    void Update()
    {
        if(health < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Game Over!");
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);  
        
        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            camAnim.SetTrigger("Shake");
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            camAnim.SetTrigger("Shake");
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
        }
    }
    public void HealthDecreaser()
    {
        health--;
        Debug.Log("Decrease Health by 1");
    }
}
