using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        Movement(Input.GetAxis("Horizontal"));
    }
    void Movement(float horizontal)
    {
        transform.Rotate(new Vector3(0,0,-speed * horizontal));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Yes!");
            Destroy(collision.gameObject);
        }
    }
}
