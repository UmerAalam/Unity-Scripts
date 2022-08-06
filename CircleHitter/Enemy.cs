using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speedDown = 0f;
    public float speedRight = 0f;

    void Update()
    {
        Movement();
    }
    void Movement()
    {
        transform.Translate(new Vector2(speedRight * Time.deltaTime,speedDown * Time.deltaTime));
    }
   
    
}
