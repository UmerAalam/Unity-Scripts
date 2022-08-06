using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     void Update()
     {
        Movement(9f);
     }
    public void Movement(float moveSpeed)
    {
     transform.Translate(Vector2.right * moveSpeed * Time.deltaTime * 2f);
    }
}
