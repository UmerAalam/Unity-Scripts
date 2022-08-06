using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = -1;
    public float speed;
    private Animator camAnim;

    private void Start()
    {
        camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }


    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);  
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            camAnim.SetTrigger("Shake");
            collision.GetComponent<PlayerMovement>().HealthDecreaser();
            Debug.Log(collision.GetComponent<PlayerMovement>().health);
            Destroy(gameObject);
        }
    }
}
